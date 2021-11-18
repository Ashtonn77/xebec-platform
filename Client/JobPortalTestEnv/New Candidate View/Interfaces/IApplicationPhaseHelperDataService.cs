
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{ 
    public interface IApplicationPhaseHelperDataService
    {
        public string Status { get; set; }
        public string ApplicationPhase { get; set; }

        // GET api/ApplicationPhaseHelpers/?UserId={AppUserId}
        Task<IEnumerable<ApplicationPhaseHelper>> GetUserAssociatedApplicationPhaseHelpers(int AppUserId);
        // GET api/ApplicationPhaseHelpers/appPhase?UserId={AppUserId}&jobId={jobId}
        Task<IEnumerable<ApplicationPhaseHelper>> GetJobAssociatedApplicationPhaseHelpers(int AppUserId, int jobId);
        //Get: api/ApplicationPhaseHelpers
        public Task<IEnumerable<ApplicationPhaseHelper>> GetAllApplicationPhaseHelpers();
        // GET api/ApplicationPhaseHelpers/{id}
        public Task<ApplicationPhaseHelper> GetApplicationPhaseHelperById(int id);
        // POST api/ApplicationPhaseHelpersController>
        public Task<ApplicationPhaseHelper> CreateApplicationPhaseHelper(ApplicationPhaseHelper editApplicationPhaseHelper);
        

        // PUT api/ApplicationPhaseHelpers/{id}
        public Task UpdateApplicationPhaseHelper(int id, ApplicationPhaseHelper ApplicationPhaseHelper);
        // DELETE api/ApplicationPhaseHelpers/{id}
        public Task DeleteApplicationPhaseHelper(int id);

        public Task GetStatus(int AppUserId, int jobId);
    }
}
