using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared.NewGamifiedModels;
using XebecPortal.Shared;
using XebecPortal.Shared.Security;

namespace Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {

        /*Authentication*/
        IGenericRepository<AppUser> AppUsers { get; } 
        /*Authentication*/   

        //Model Repositories
        IGenericRepository<AdditionalInformation> AdditionalInformation { get; }
        IGenericRepository<Application> Applications { get; }
        IGenericRepository<ApplicationPhase> Phases { get; }
        IGenericRepository<ApplicationPhaseHelper> ApplicationPhaseHelpers { get; }
        IGenericRepository<Document> Documents { get; }
      
        IGenericRepository<Education> Education { get; }
        
        IGenericRepository<Job> Jobs { get; }
        IGenericRepository<JobType> JobTypes { get; }
        IGenericRepository<JobTypeHelper> JobTypeHelpers { get; }
        IGenericRepository<LoginHelper> LoginHelpers { get; }
        IGenericRepository<PersonalInformation> PersonalInformation { get; }
        IGenericRepository<RegisterHelper> RegisterHelpers { get; }
        IGenericRepository<Status> Statuses { get; }
        IGenericRepository<WorkHistory> WorkHistory { get; }
        

        /*newly added*/
        IGenericRepository<PersonalTestInfo> PersonalTestInfos { get; }

        IGenericRepository<EducationTest> EducationTests { get; }

        IGenericRepository<WorkHistoryTest> WorkHistoryTests { get; }

        IGenericRepository<AdditionalInformationTest> AdditionalInformationTests { get; }
         /*newly added*/

        //Added new repository
        IGenericRepository<JobPlatform> JobPlatforms { get; }
        IGenericRepository<JobPlatformHelper> JobPlatformHelpers { get; }


        //Newly Added (Kian) 
        IGenericRepository<ProfilePortfolioLink> ProfilePortfolioLinks { get; }

        //New tables
        IGenericRepository<Department> Departments { get; }

        IGenericRepository<Citizenship> Citizenships { get; }

        IGenericRepository<IdealCandidate> IdealCandidates { get; }

        IGenericRepository<Location> Locations { get; }

        IGenericRepository<NoticePeriod> NoticePeriods { get; }

        IGenericRepository<Permission> Permissions { get; }

        IGenericRepository<Questionnaire> Questnionnaires { get; }

        IGenericRepository<Result> Results { get; }

        IGenericRepository<Visa> Visas { get; }

        IGenericRepository<WorkPermit> WorkPermits { get; }



        //Saving to the DB
        Task Save();

    }
}
