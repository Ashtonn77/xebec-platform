using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class JobPlatformConfiguration : IEntityTypeConfiguration<JobPlatform>
    {
       
        public void Configure(EntityTypeBuilder<JobPlatform> builder)
        {
            builder.HasData
            (
                new JobPlatform
                {
                     Id = 1,
                     PlatformName = "LinkedIn",
                },
                 new JobPlatform
                 {
                     Id = 2,
                     PlatformName = "Indeed",
                 },
                  new JobPlatform
                  {
                      Id = 3,
                      PlatformName = "Twitter",
                  }
            );
        }
    }
}