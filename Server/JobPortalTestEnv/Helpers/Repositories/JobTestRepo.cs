using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.IRepository;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Server.JobPortalTestEnv.Helpers.Repositories
{
    public class JobTestRepo : GenericRepository<Job>, IJobTestRepo
    {
        public JobTestRepo(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Job>> SearchJobs(string SearchQuery, string jobtypeQuery)
        {
            IQueryable<Job> query = _context.Jobs;
            //Search parameters
            if (!string.IsNullOrEmpty(SearchQuery))
            {
                query =  query.Where(j => j.Title.Contains(SearchQuery) || j.Compensation.Contains(SearchQuery) || j.Location.Contains(SearchQuery));
            }
            if (!string.IsNullOrEmpty(jobtypeQuery))
            {
                int sdf = int.Parse(jobtypeQuery);
                if (sdf >= 1 && sdf <= 3)
                {
                    var werQuery = from photo in query
                                   join person in _context.JobTypeHelpers.Where(m => m.JobTypeID == sdf)
                                       on photo.Id equals person.JobID
                                   select photo;
                    //Searches for job titles, compensation and locations based on what user entered
                    return await werQuery.AsNoTracking().ToListAsync();
                }
            }
           
            //Searches for job titles, compensation and locations based on what user entered
            return await query.AsNoTracking().ToListAsync();
        }

        
    }
}
