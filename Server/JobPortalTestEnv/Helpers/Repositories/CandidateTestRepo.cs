using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Server.JobPortalTestEnv.Helpers.Repositories
{
    public class CandidateTestRepo : GenericRepository<User>, ICandidateTestRepo
    {
        public CandidateTestRepo(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<PersonalInformation>> GetApplications(int JobId)
        {
            IQueryable<PersonalInformation> queryFinal;
            //var job = new SqlParameter("jobId", JobId);
            //IQueryable<PersonalInformation> queryFinal = _context.PersonalInformations.
            //    FromSqlRaw("SELECT * from PersonalInformations Where UserId IN (SELECT UserId FROM Applications where JobId = @jobId)", job);

            queryFinal = from users in _context.Users
                    join applications in _context.Applications.Where(a => a.JobId == JobId)
                        on users.Id equals applications.UserId
                    join info in _context.PersonalInformations
                     on users.Id equals info.UserId
                    select info;

            return await queryFinal.AsNoTracking().ToListAsync();
        }

        public async Task<List<User>> GetApplicantIds(int JobId)
        {
            IQueryable<User> queryFinal;
          

            queryFinal = from users in _context.Users
                         join applications in _context.Applications.Where(a => a.JobId == JobId)
                             on users.Id equals applications.UserId
                         select users;

            return await queryFinal.AsNoTracking().ToListAsync();
        }

        public async Task<List<PersonalInformation>> SearchCandidates(int JobId, string SearchQuery, string ethnicityFiler, string GenderFilter, string disabilityFilter)
        {

            
            IQueryable<PersonalInformation> queryPI = _context.PersonalInformations;
            IQueryable<WorkHistory> queryWH = _context.WorkHistories;
            IQueryable<Education> queryEd = _context.Educations;

            //GetApplications for sepecific job
            IQueryable<User> query = from users in _context.Users
                                     join applications in _context.Applications.Where(a => a.JobId == JobId)
                                         on users.Id equals applications.UserId
                                     select users;
            //Search name and surname
            if (!string.IsNullOrEmpty(SearchQuery))
            {
                query = from user in query
                               join personalinfo in _context.PersonalInformations.
                               Where(p => p.FirstName.Contains(SearchQuery) || p.LastName.Contains(SearchQuery))
                                   on user.Id equals personalinfo.UserId
                               select user;
            }
            //filter by ethnicity
            if (!string.IsNullOrEmpty(ethnicityFiler))
            {
                    query = from user in query
                                   join person in _context.PersonalInformations.Where(e => e.Ethnicity.Contains(ethnicityFiler))
                                       on user.Id equals person.UserId
                                   select user;
                    //Searches for job titles, compensation and locations based on what user entered
            }
            //filter by gender
            if (!string.IsNullOrEmpty(GenderFilter))
            {
                query = from user in query
                               join person in _context.PersonalInformations.Where(e => e.Gender.Equals(GenderFilter))
                                   on user.Id equals person.UserId
                               select user;
                //Searches for job titles, compensation and locations based on what user entered
            }
            //filter by disability
            if (!string.IsNullOrEmpty(disabilityFilter))
            {
                bool isDisabled = disabilityFilter.Contains("disabled");
                query = from user in query
                               join person in _context.PersonalInformations.Where(e => e.Disability == isDisabled)
                                   on user.Id equals person.UserId
                               select user;
                //Searches for job titles, compensation and locations based on what user entered
            }
            queryPI = from users in query
                      join applications in queryPI
                          on users.Id equals applications.UserId
                      select applications;
            //Searches for job titles, compensation and locations based on what user entered
            return await queryPI.AsNoTracking().ToListAsync();
        }

    }
}
