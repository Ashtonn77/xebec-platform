using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {

        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.HasData
            (
                new Application
                {
                    Id = 1,
                    UserId = 1,
                    JobId = 1,
                    TimeApplied = DateTime.Now.AddMinutes(2)

                }
            );
        }
    }
}