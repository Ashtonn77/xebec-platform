using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Server.JobPortalTestEnv.Helpers.Repositories
{
    public interface ICandidateTestRepo
    {
        Task<List<PersonalInformation>> SearchCandidates(int JobId, string SearchQuery, string ethnicityFiler, string GenderFilter, string disabilityFilter);
        Task<List<PersonalInformation>> GetApplications(int JobId);
        Task<List<User>> GetApplicantIds(int JobId);
    }
}
