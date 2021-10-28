using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.Jobport_3.Pages
{
    public partial class JobPostingExperiement
    {

        #region Component Lifeycle Methods

        //Initialising
        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            try
            {
                LstJobs = await HttpClient.GetFromJsonAsync<List<Job>>("api/job");
                JobTypes = await HttpClient.GetFromJsonAsync<List<JobType>>("api/jobtype");

                  if (LstJobs != null)
                  {
                        CurrentJob2 = LstJobs[0];
                  }

            }
            catch (Exception ex)
            {
                LstJobs = new List<Job>();
                JobTypes = new List<JobType>();
            }

          
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await jsr.InvokeVoidAsync("initialize"); //Calls the initialize function from the javascript file.
            }
        }

        #endregion


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


        #endregion


        #region Searching and Filtering

        public string SearchTerm { get; set; } = String.Empty;
        public string JobFilter { get; set; } = String.Empty;
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
                SearchedJobs = await HttpClient.GetFromJsonAsync<List<Job>>($"api/jobtest/?searchQuery={SearchTerm}&jobtypeQuery={JobFilter}");
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

        #endregion

    }
}
