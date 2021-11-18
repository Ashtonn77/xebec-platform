using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public class JobDataService : IJobDataService
    {
        private readonly HttpClient _httpClient;

        public JobDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Job>> GetAllJobes()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Job>>
                (await _httpClient.GetStreamAsync($"api/job"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Job> GetJobById(int JobId)
        {
            return await JsonSerializer.DeserializeAsync<Job>
                (await _httpClient.GetStreamAsync($"api/job/{JobId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task UpdateJob(int id, Job Job)
        {
            var JobJson =
                new StringContent(JsonSerializer.Serialize(Job), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"api/job/{id}", JobJson);
        }

        public async Task DeleteJob(int JobId)
        {
            await _httpClient.DeleteAsync($"api/job/{JobId}");
        }
    }
}
