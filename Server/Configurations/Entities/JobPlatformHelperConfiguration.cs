using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class JobPlatformHelperConfiguration : IEntityTypeConfiguration<JobPlatformHelper>
    {
       
        public void Configure(EntityTypeBuilder<JobPlatformHelper> builder)
        {
            builder.HasData
            (
                new JobPlatformHelper
                {
                     Id = 1,
                     JobID = 1,
                     JobPlatformId = 1
                },
                 new JobPlatformHelper
                 {
                     Id = 2,
                     JobID = 2,
                     JobPlatformId = 2
                 }

            );
        }
    }
}