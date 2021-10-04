using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class ApplicationPhaseHelperConfiguration : IEntityTypeConfiguration<ApplicationPhaseHelper>
    {

        public void Configure(EntityTypeBuilder<ApplicationPhaseHelper> builder)
        {
            builder.HasData
            (
                new ApplicationPhaseHelper
                {
                    Id = 1,
                    ApplicationId = 1,
                    PhaseId = 1,
                    StatusId = 1,
                    Comments = "Good Candidate, has potential to rule all of Westeros",
                    TimeMoved = DateTime.Now
                },
               new ApplicationPhaseHelper
               {
                   Id = 2,
                   ApplicationId = 1,
                   PhaseId = 2,
                   StatusId = 1,
                   Comments = "Interview went well, He's really got potential",
                   TimeMoved = DateTime.Now.AddDays(2)
               },
                 new ApplicationPhaseHelper
                 {
                     Id = 3,
                     ApplicationId = 1,
                     PhaseId = 3,
                     StatusId = 2,
                     Comments = "He's good, but won't become king",
                     TimeMoved = DateTime.Now.AddMonths(2)
                 }
            );
        }
    }
}