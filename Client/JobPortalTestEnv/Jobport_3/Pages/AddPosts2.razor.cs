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

        List<int> jobPlatformHelper = new List<int>();

        int[] jobTypeHelper = new int[0];

        private static Action<string> countryAction;
        protected override async Task OnInitializedAsync()
        {            

            try
            {
                jobTypes = await httpClient.GetFromJsonAsync<List<JobType>>("api/JobType");
                jobPlatform = await httpClient.GetFromJsonAsync<List<JobPlatform>>("api/JobPlatform");
            }
            catch(Exception ex)
            {
                jobTypes = new List<JobType>();
                jobPlatform = new List<JobPlatform>();
            }

            job.CreationDate = DateTime.Now;
            countryAction = UpdateModelData;
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
        private Task OnDepartmentChanged(ChangeEventArgs e)
        {
            job.Department = e.Value.ToString();
            return ValueChanged.InvokeAsync(job.Department);
        }
        private void UpdateModelData(string value)
        {
            if(value != "")
            {
                int i = 0;
                string[] numbers = value.Split(',');
                int[] splitNumbers = new int[numbers.Length];
                Array.Resize(ref jobTypeHelper, numbers.Length);

                foreach (var items in numbers)
                {
                    splitNumbers[i] = int.Parse(items);
                    i++;
                }
                jobTypeHelper = splitNumbers;
            }
            else
            {
                jobTypeHelper = null;
            }
            StateHasChanged();
        }

        [JSInvokable]
        public static void UpdateModel(string value)
        {
            countryAction.Invoke(value);
        }

        private void CheckboxClicked(int idPlatform, object checkedValue)
        {
            int i = 0;
            int[] list = new int[4];

            if ((bool)checkedValue)
            {
                if (!jobPlatformHelper.Contains(idPlatform))
                {
                    jobPlatformHelper.Add(idPlatform);
                }
            }
            else
            {
                if (jobPlatformHelper.Contains(idPlatform))
                {
                    jobPlatformHelper.Remove(idPlatform);
                }
            }
        }
        private async Task SendData()
        {
            await httpClient.PostAsJsonAsync("api/Job", job);
            await httpClient.PostAsJsonAsync("api/JobPlatform", jobPlatformHelper);
            if(jobTypeHelper != null)
                await httpClient.PostAsJsonAsync("api/JobTypeHelper", jobTypeHelper);
            //await httpClient.PostAsJsonAsync("https://prod-43.westeurope.logic.azure.com:443/workflows/8cbad277b9d84caf9121b54eb2652dba/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=o6pIiibRSUm7H6RS_BQgElgY9PWnzjqSTqkCMULIn_0", job);
            await JsRuntime.InvokeVoidAsync("alert", "Successfully Posted A New Job Post");
        }

    }
}
