using System.Collections.Generic;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public interface IPersonalInformationDataService
    {
        PersonalInformation SavedPersonalInformation { get; set; }

        // GET: api/PersonalInformation/
        Task<IEnumerable<PersonalInformation>> GetAllPersonalInformations();

        // GET api/PersonalInformation/single/{id}
        Task<PersonalInformation> GetPersonalInformationDetails(int PersonalInformationId);

        //get by appuserId
        // GET api/PersonalInformation/{id}
        Task<PersonalInformation> GetSibglePersonalInformationByUserID(int AppUserId);

        //get by appuserId
        // GET api/PersonalInformation/all/{id}
        Task<IEnumerable<PersonalInformation>> GetPersonalInformationsByUserID(int id);

        // GET api/PersonalInformation/?email={email}
        Task<PersonalInformation> GetPersonalInfoByEmail(string email);

        //// GET api/PersonalInformation/candidates/{jobId}
        //Task<IEnumerable<PersonalInformation>> SearchApplicants(string jobId, string SearchQuery, string ethnicityFiler, string GenderFilter, string disabilityFilter);

        //// GET api/PersonalInformation/additional?disability=disabled
        //Task<IEnumerable<PersonalInformation>> GetPersonalInfoByAdditionalInfo(string disability, string gender, string ehtnicity);
        // POST api/PersonalInformation/
        Task<PersonalInformation> AddPersonalInformation(PersonalInformation PersonalInformation);

        // PUT api/PersonalInformation/{id}
        Task UpdatePersonalInformation(PersonalInformation PersonalInformation);

        // DELETE api/PersonalInformation/{id}
        Task DeletePersonalInformation(int PersonalInformationId);
    }
}