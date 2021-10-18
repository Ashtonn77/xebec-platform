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
    public partial class AddPosts2
    {
        List<JobPlatform> jobPlatform { get; set; } = new List<JobPlatform>();
        List<JobType> jobTypes { get; set; } = new List<JobType>();
        List<JobTypeHelper> jobTypeHelpers { get; set; } = new List<JobTypeHelper>();
        List<JobPlatformHelper> platformHelper { get; set; } = new List<JobPlatformHelper>();
        protected override async Task OnInitializedAsync()
        {
            jobTypes = await httpClient.GetFromJsonAsync<List<JobType>>("api/JobType");
            jobPlatform = await httpClient.GetFromJsonAsync<List<JobPlatform>>("api/JobPlatform");
            job.CreationDate = DateTime.Now;
            await base.OnInitializedAsync();
        }
        protected override async void OnAfterRender(bool firstRender)
        {
            await JsRuntime.InvokeVoidAsync("select2");
            base.OnAfterRender(firstRender);
        }

        private void toWorkHistory()
        {
            NavigationManager.NavigateTo("/work-history");
        }

        private void toIndex()
        {
            NavigationManager.NavigateTo("/");
        }

        //This is the model that we bind to the form
        public Job job { get; set; } = new Job();

        //This is the event callback we use in the select drop down elements
        [Parameter]
        public EventCallback<string> ValueChanged
        {
            get;
            set;
        }

        /*The function we trigger when we interact with the job type drop down
        It simply binds the value from the drop down to the job type field in the model
        private Task OnJobTypeChanged(ChangeEventArgs e)
        {
            job.JobType = e.Value.ToString();
            return ValueChanged.InvokeAsync(job.JobType);
        }*/

        /*The function we trigger when we interact with the department drop down
        It simply binds the value from the drop down to the department field in the model*/
        private Task OnDepartmentChanged(ChangeEventArgs e)
        {
            job.Department = e.Value.ToString();
            return ValueChanged.InvokeAsync(job.Department);
        }

        private async Task SendData()
        {
            await httpClient.PostAsJsonAsync("https://prod-43.westeurope.logic.azure.com:443/workflows/8cbad277b9d84caf9121b54eb2652dba/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=o6pIiibRSUm7H6RS_BQgElgY9PWnzjqSTqkCMULIn_0", job);
        }

    }
}
