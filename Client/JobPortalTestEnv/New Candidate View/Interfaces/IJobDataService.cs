using System.Collections.Generic;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv
{
    public interface IJobDataService
    {
        // GET: api/<JobesController>
        Task<IEnumerable<Job>> GetAllJobes();

        // GET api/<JobesController>/{id}
        Task<Job> GetJobById(int JobId);

        // POST api/<JobesController>
        //Task<Job> CreateJob(Job Job);

        // PUT api/<JobesController>/{id}
        Task UpdateJob(int id, Job Job);

        // DELETE api/<JobesController>/{id}
        Task DeleteJob(int id);
    }
}