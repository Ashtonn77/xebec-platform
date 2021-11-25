using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public class StatusDataService : IStatusDataService
    {
        private readonly HttpClient _httpClient;

        public StatusDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Status>> GetAllStatuses()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Status>>
                (await _httpClient.GetStreamAsync($"api/Status"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Status> GetStatusById(int StatusId)
        {
            return await JsonSerializer.DeserializeAsync<Status>
                (await _httpClient.GetStreamAsync($"api/Status{StatusId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateStatus(int id, Status Status)
        {
            var StatusJson =
                new StringContent(JsonSerializer.Serialize(Status), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/Status/{id}", StatusJson);
        }

        public async Task DeleteStatus(int StatusId)
        {
            await _httpClient.DeleteAsync($"api/Status/{StatusId}");
        }
    }
}