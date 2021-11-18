using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public class ApplicationPhaseHelperDataService : IApplicationPhaseHelperDataService
    {
        private readonly HttpClient _httpClient;

        public ApplicationPhaseHelperDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ApplicationPhaseHelper>> GetUserAssociatedApplicationPhaseHelpers(int AppUserId)
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ApplicationPhaseHelper>>
                (await _httpClient.GetStreamAsync($"api/ApplicationPhaseHelpers/?UserId={AppUserId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task<IEnumerable<ApplicationPhaseHelper>> GetJobAssociatedApplicationPhaseHelpers(int AppUserId, int jobId)
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ApplicationPhaseHelper>>
                (await _httpClient.GetStreamAsync($"api/ApplicationPhaseHelpers/appPhase?UserId={AppUserId}&jobId={jobId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<ApplicationPhaseHelper> CreateApplicationPhaseHelper(ApplicationPhaseHelper editApplicationPhaseHelper)
        {
            var ApplicationPhaseHelperJson =
                new StringContent(JsonSerializer.Serialize(editApplicationPhaseHelper), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/ApplicationPhaseHelper", ApplicationPhaseHelperJson);

            if (response.IsSuccessStatusCode)
            {
                await JsonSerializer.DeserializeAsync<ApplicationPhaseHelper>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task UpdateApplicationPhaseHelper(int id, ApplicationPhaseHelper ApplicationPhaseHelper)
        {
            var ApplicationPhaseHelperJson =
                new StringContent(JsonSerializer.Serialize(ApplicationPhaseHelper), Encoding.UTF8, "application/json");

            await _httpClient.PutAsJsonAsync($"api/ApplicationPhaseHelper/{id}", ApplicationPhaseHelperJson);
        }

        public async Task<IEnumerable<ApplicationPhaseHelper>> GetAllApplicationPhaseHelpers(int appUserId)
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ApplicationPhaseHelper>>
                (await _httpClient.GetStreamAsync($"api/ApplicationPhaseHelper"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task DeleteApplicationPhaseHelper(int ApplicationPhaseHelperId)
        {
            await _httpClient.DeleteAsync($"api/ApplicationPhaseHelper/{ApplicationPhaseHelperId}");
        }

        public async Task<ApplicationPhaseHelper> GetApplicationPhaseHelperById(int ApplicationPhaseHelperId)
        {
            return await JsonSerializer.DeserializeAsync<ApplicationPhaseHelper>
                (await _httpClient.GetStreamAsync($"api/ApplicationPhaseHelper/{ApplicationPhaseHelperId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public string Status { get; set; }
        public string ApplicationPhase { get; set; }

        public async Task GetStatus(int AppUserId, int jobId )
        {
           var ApplicaionPhaseHelpers = await GetJobAssociatedApplicationPhaseHelpers(AppUserId, jobId);
            Status errorstatus = new Status
            {
                Id = 1,
                Description = "Error: No status"
            };
            ApplicationPhase errorApplication = new ApplicationPhase
            {
                Id = 1,
                Description = "Error: No status"
            };
            ApplicationPhaseHelper ApplicaionPhaseHelper = new ApplicationPhaseHelper
            {
                ApplicationId = 0,
                StatusId = 1,
                Status = errorstatus,
                ApplicationPhaseId = 1,
                ApplicationPhase = errorApplication
            };
            var temp = ApplicaionPhaseHelpers.Last();
            if(temp != null)
            {
                ApplicaionPhaseHelper = temp;
            }
            Status = ApplicaionPhaseHelper.Status.Description;
            ApplicationPhase = ApplicaionPhaseHelper.ApplicationPhase.Description;
        }

        public Task<IEnumerable<ApplicationPhaseHelper>> GetAllApplicationPhaseHelpers()
        {
            throw new NotImplementedException();
        }
    }
}
