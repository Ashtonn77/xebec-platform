using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XebecPortal.Shared.NewGamifiedModels;
using XebecPortal.Shared;
using XebecPortal.Shared.Security;

namespace Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        /*Authentication*/
        public DbSet<AppUser> AppUser { get; set; }
        /*Authentication*/

        public DbSet<AdditionalInformation> AdditionalInformations { get; set;}
        public DbSet<Application> Applications { get; set;}
        public DbSet<ApplicationPhase> ApplicationPhases { get; set; }
        public DbSet<ApplicationPhaseHelper> ApplicationPhasesHelpers { get; set;}
        public DbSet<Document> Documents { get; set;}
     
        public DbSet<Education> Educations { get; set;}
     
        public DbSet<Job> Jobs { get; set;}
        public DbSet<JobType> JobTypes { get; set;}
        public DbSet<JobTypeHelper> JobTypeHelpers { get; set;}
        public DbSet<LoginHelper> LoginHelpers { get; set;}
        public DbSet<PersonalInformation> PersonalInformations { get; set;}
        public DbSet<RegisterHelper> RegisterHelpers { get; set;}
        public DbSet<Status> Statuses { get; set;}
       
        public DbSet<WorkHistory> WorkHistories { get; set;}
     

        /*newly added*/
        public DbSet<PersonalTestInfo> PersonalTestInfos { get; set; }
        public DbSet<EducationTest> EducationTests { get; set; }
        public DbSet<WorkHistoryTest> WorkHistoryTests { get; set; }
        public DbSet<AdditionalInformationTest> AdditionalInformationTests { get; set; }
        /*newly added*/

        //Added new DB Sets
        public DbSet<JobPlatform> JobPlatforms { get; set; }
        public DbSet<JobPlatformHelper> JobPlatformHelpers { get; set; }

        //Newly Added(Kian) 
        public DbSet<ProfilePortfolioLink> ProfilePortfolioLinks { get; set; }


        //New table changes
        public DbSet<Visa> Visas { get; set; }

        public DbSet<WorkPermit> WorkPermits { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<NoticePeriod> NoticePeriods { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Citizenship> Citizenships { get; set; }

        public DbSet<IdealCandidate> IdealCandidates { get; set; }

        public DbSet<Questionnaire> Questionnaires { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Result> Results { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);          
        }

    }
}