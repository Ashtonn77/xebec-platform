using System.Collections.Generic;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public interface IStatusDataService
    {
        // GET: api/<StatusesController>
        Task<IEnumerable<Status>> GetAllStatuses();
        // GET api/<StatusesController>/{id}
        Task<Status> GetStatusById(int StatusId);

        // POST api/<StatusesController>
        //Task<Status> CreateStatus(Status Status);

        // PUT api/<StatusesController>/{id}
        Task UpdateStatus(int id, Status Status);

        // DELETE api/<StatusesController>/{id}
        Task DeleteStatus(int id);
    }
}
