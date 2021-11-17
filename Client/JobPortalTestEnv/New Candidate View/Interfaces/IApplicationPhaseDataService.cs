using System.Collections.Generic;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public interface IApplicationPhaseDataService
    {
        Task<IEnumerable<ApplicationPhase>> GetAllApplicationPhases();
        Task<ApplicationPhase> GetApplicationPhaseById(int ApplicationPhaseId);
        //Task<ApplicationPhase> CreateApplicationPhase(ApplicationPhase Phase);
        Task UpdateApplicationPhase(int id, ApplicationPhase Phase);
        Task DeleteApplicationPhase(int id);
    }
}
