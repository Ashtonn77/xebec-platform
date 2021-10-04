using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class StatusConfiguration : IEntityTypeConfiguration<Status>
    {
       
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData
            (
                new Status
                {
                     Id = 1,
                     Description = "In Progress",

                },
                 new Status
                 {
                     Id = 2,
                     Description = "Regreted",

                 },
                  new Status
                  {
                      Id = 3,
                      Description= "Hired",

                  }
            );
        }
    }
}