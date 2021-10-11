using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Configurations.Entities;
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

        public DbSet<AdditionalInformation> AdditionalInformations { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationPhase> ApplicationPhases { get; set; }
        public DbSet<ApplicationPhaseHelper> ApplicationPhasesHelpers { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentHelper> DocumentHelpers { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationHelper> EducationHelpers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobTypeHelper> JobTypeHelpers { get; set; }
        public DbSet<LoginHelper> LoginHelpers { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<RegisterHelper> RegisterHelpers { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkHistory> WorkHistories { get; set; }
        public DbSet<WorkHistoryHelper> WorkHistoryHelpers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.ApplyConfiguration(new JobConfiguration());

            modelBuilder.ApplyConfiguration(new PersonalInformationConfiguration());

            modelBuilder.ApplyConfiguration(new AdditionalInformationConfiguration());

            modelBuilder.ApplyConfiguration(new JobTypeConfiguration());
            modelBuilder.ApplyConfiguration(new JobTypeHelperConfiguration());

            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationPhaseConfiguration());
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationPhaseHelperConfiguration());

            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new EducationHelperConfiguration());

            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentHelperConfiguration());

            modelBuilder.ApplyConfiguration(new WorkHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new WorkHistoryHelperConfiguration());
        }

    }
}