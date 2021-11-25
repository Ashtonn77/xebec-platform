using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public class PersonalInformationDataService : IPersonalInformationDataService
    {
        private readonly HttpClient _httpClient;
        public PersonalInformation SavedPersonalInformation { get; set; }

        public PersonalInformationDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<PersonalInformation>> GetAllPersonalInformations()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<PersonalInformation>>
                (await _httpClient.GetStreamAsync($"api/PersonalInformation"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<PersonalInformation> GetPersonalInformationDetails(int PersonalInformationId)
        {
            return await JsonSerializer.DeserializeAsync<PersonalInformation>
                (await _httpClient.GetStreamAsync($"api/PersonalInformation/{PersonalInformationId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<PersonalInformation> GetSibglePersonalInformationByUserID(int AppUserId)
        {
            return await JsonSerializer.DeserializeAsync<PersonalInformation>
                (await _httpClient.GetStreamAsync($"api/PersonalInformation/{AppUserId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<PersonalInformation>> GetPersonalInformationsByUserID(int id)
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<PersonalInformation>>
                (await _httpClient.GetStreamAsync($"api/PersonalInformation/all/{id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<PersonalInformation> GetPersonalInfoByEmail(string email)
        {
            return await JsonSerializer.DeserializeAsync<PersonalInformation>
                (await _httpClient.GetStreamAsync($"api/PersonalInformation/?email={email}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        //public async Task<PersonalInformation> SearchApplicants(string jobId, string SearchQuery, string ethnicityFiler, string GenderFilter, string disabilityFilter)
        //{
        //    return await JsonSerializer.DeserializeAsync<PersonalInformation>
        //        (await _httpClient.GetStreamAsync($"api/PersonalInformation/candidates/?{jobId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        //}

        public async Task<PersonalInformation> AddPersonalInformation(PersonalInformation Candidate)
        {
            var PersonalInformationJson =
                new StringContent(JsonSerializer.Serialize(Candidate), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/PersonalInformation", PersonalInformationJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<PersonalInformation>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task UpdatePersonalInformation(PersonalInformation Candidate)
        {
            var PersonalInformationJson =
                new StringContent(JsonSerializer.Serialize(Candidate), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync("api/PersonalInformation", PersonalInformationJson);
        }

        public async Task DeletePersonalInformation(int PersonalInformationId)
        {
            await _httpClient.DeleteAsync($"api/PersonalInformation/{PersonalInformationId}");
        }
    }
}