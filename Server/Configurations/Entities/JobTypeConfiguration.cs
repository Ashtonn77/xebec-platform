using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class JobTypeConfiguration : IEntityTypeConfiguration<JobType>
    {
       
        public void Configure(EntityTypeBuilder<JobType> builder)
        {
            builder.HasData
            (
                new JobType
                {
                     Id = 1,
                     Type = "Full-Time",
                },
                 new JobType
                 {
                     Id = 2,
                     Type = "Part-Time",
                 },
                  new JobType
                  {
                      Id = 3,
                      Type = "Internship",
                  }
            );
        }
    }
}