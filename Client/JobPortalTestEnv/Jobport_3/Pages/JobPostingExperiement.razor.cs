using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.Jobport_3.Pages
{
    public partial class JobPostingExperiement
    {
        #region Component Lifeycle Methods

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await jsr.InvokeVoidAsync("initialize"); //Calls the initialize function from the javascript file.
            }
        }

        #endregion Component Lifeycle Methods

        #region Mainparts

        public List<Job> LstJobs { get; set; }
        public Job CurrentJob2 { get; set; } = new Job();
        public List<JobType> JobTypes { get; set; }

        private void ViewJob(Job JobToView)
        {
            CurrentJob2 = JobToView;
        }

        private void ViewCandidates(Job selectedJob)
        {
            NavManager.NavigateTo($"candidateinfoexp/{selectedJob.Id}");
        }

        #endregion Mainparts

        #region Searching and Filtering

        private string SearchTerm { get; set; } = String.Empty;
        private string SearchLocation { get; set; } = String.Empty;
        private string JobFilter { get; set; } = String.Empty;
        private bool jobFilterApplied = false;
        private List<Job> SearchedJobs { get; set; } = new List<Job>();

        private void onValChanged(Microsoft.AspNetCore.Components.ChangeEventArgs args)
        {
            JobFilter = args.Value.ToString();
            jobFilterApplied = true;
            SearchEvent();
        }

        private void Clear()
        {
            jobFilterApplied = false;
            JobFilter = string.Empty;
            SearchEvent();
        }

        private void RealSearch()
        {
            SearchEvent();
        }

        private async Task<List<Job>> SearchEvent()
        {
            try
            {
                SearchedJobs = await HttpClient.GetFromJsonAsync<List<Job>>($"api/jobtest/?searchQuery={SearchTerm}&searchLocation={SearchLocation}&jobtypeQuery={JobFilter}");
            }
            catch (Exception ex)
            {
                SearchedJobs = new List<Job>();
            }

            if (SearchedJobs.Count > 0)
            {
                CurrentJob2 = SearchedJobs[0];
            }
            LstJobs = SearchedJobs;
            InvokeAsync(StateHasChanged);
            return LstJobs;
        }

        #endregion Searching and Filtering
    }
}