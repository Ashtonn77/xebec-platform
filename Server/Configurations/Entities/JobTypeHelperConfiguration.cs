using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class JobTypeHelperConfiguration : IEntityTypeConfiguration<JobTypeHelper>
    {
       
        public void Configure(EntityTypeBuilder<JobTypeHelper> builder)
        {
            builder.HasData
            (
                new JobTypeHelper
                {
                     Id = 1,
                     JobID =1,
                     JobTypeID =1
                },
                 new JobTypeHelper
                 {
                     Id = 2,
                     JobID = 1,
                     JobTypeID = 2
                 }
            );
        }
    }
}