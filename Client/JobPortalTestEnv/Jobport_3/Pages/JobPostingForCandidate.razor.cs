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
    public partial class JobPostingForCandidate
    {
        //Show and Hide Element
        private bool IsShown { get; set; } = false;
        // Search variable
        private static string searchTerm = string.Empty;

        private List<Application> applications = new List<Application>();
        private static List<Job> Jobs = new List<Job>();

        protected override async Task OnInitializedAsync()
        {
            Jobs = await httpClient.GetFromJsonAsync<List<Job>>("api/Job");

            await base.OnInitializedAsync();

            if (Jobs != null)
            {
                DisplayJobs = Jobs;
                if (Jobs.Count > 0)
                {
                    CurrentJob2 = Jobs[0];
                }
            }

            if (applications.Count(x => x.JobId == CurrentJob2.Id && x.UserId == 2) >= 1)
                IsShown = true;
            else
                IsShown = false;

        }

        public Job EditJob { get; set; } = new Job();

        public List<Job> DisplayJobs { get; set; }

        public Job CurrentJob2 { get; set; } = new Job();

        private async Task ViewJob(Job JobToView)
        {
            applications = await httpClient.GetFromJsonAsync<List<Application>>("api/Application");

            if (applications.Count(x => x.JobId == JobToView.Id && x.UserId == 2) >= 1)
                IsShown = true;
            else
                IsShown = false;

            CurrentJob2 = JobToView;
        }

        private static List<Job> SearchResults = Jobs;

        private static bool isFound = false;

        public string SearchTerm { get; set; } = String.Empty;

        public void NewSearch()
        {
            string lookingFor = SearchTerm.ToLower();
            List<Job> TempJObs = Jobs.FindAll(q => (q.Title.ToLower().Contains(lookingFor) || q.Location.ToLower().Contains(lookingFor)));

            if (TempJObs.Count < 1)
            {
                //Look under Discription
                TempJObs = Jobs.FindAll(q => q.Description.ToLower().Contains(lookingFor) || q.Compensation.ToString().ToLower().Contains(lookingFor));
            }

            //if found
            if (TempJObs.Count > 0)
            {
                DisplayJobs = TempJObs;
            }
            else
            {
                //Display alert item no found
                //Todo
            }
        }

        private void onChange(ChangeEventArgs args)
        {
            SearchTerm = (string)args.Value;
            if (string.IsNullOrWhiteSpace(SearchTerm))
            {
                DisplayJobs = Jobs;
            }
        }

        // Apply Function
        private async Task Apply()
        {
            await httpClient.PostAsJsonAsync("api/Application", CurrentJob2);
            await jsr.InvokeVoidAsync("alert", "You Have Applied Successfully");
            IsShown = !IsShown;
        }

        private bool IsClicked = false;

        private int ReturnedJobId = 0;

        private Job CurrentJob = null;

        //Method for when a summary box is clicked. Uses the JobPostingTest.js in the js folder inside the wwwroot.
        private async Task On()
        {
            IsClicked = true;
            ReturnedJobId = Int32.Parse(await jsr.InvokeAsync<string>("show")); //Calls the show function from the javascript file.

            CurrentJob = SearchResults.FirstOrDefault(q => q.Id == ReturnedJobId);
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await jsr.InvokeVoidAsync("initialize"); //Calls the initialize function from the javascript file.
            }
        }
    }
}