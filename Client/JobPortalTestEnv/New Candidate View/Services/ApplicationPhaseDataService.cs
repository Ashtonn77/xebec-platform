using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public class ApplicationPhaseDataService : IApplicationPhaseDataService
    {
        private readonly HttpClient _httpClient;

        public ApplicationPhaseDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ApplicationPhase>> GetAllApplicationPhases()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<ApplicationPhase>>
                (await _httpClient.GetStreamAsync($"api/ApplicationPhase"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<ApplicationPhase> GetApplicationPhaseById(int ApplicationPhaseId)
        {
            return await JsonSerializer.DeserializeAsync<ApplicationPhase>
                (await _httpClient.GetStreamAsync($"api/ApplicationPhase/{ApplicationPhaseId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        public async Task UpdateApplicationPhase(int id, ApplicationPhase ApplicationPhase)
        {
            var ApplicationPhaseJson =
                new StringContent(JsonSerializer.Serialize(ApplicationPhase), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/ApplicationPhase/{id}", ApplicationPhaseJson);
        }

        public async Task DeleteApplicationPhase(int ApplicationPhaseId)
        {
            await _httpClient.DeleteAsync($"api/ApplicationPhase/{ApplicationPhaseId}");
        }
    }
}
