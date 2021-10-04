using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class ApplicationPhaseConfiguration : IEntityTypeConfiguration<ApplicationPhase>
    {
        public void Configure(EntityTypeBuilder<ApplicationPhase> builder)
        {
            builder.HasData
            (
                new ApplicationPhase
                {
                    Id = 1,
                    Description = "Phone Screen",

                },
                new ApplicationPhase
                {
                    Id = 2,
                    Description = "First Interview",

                },
                 new ApplicationPhase
                 {
                     Id = 3,
                     Description = "Second Interview",

                 },

                 new ApplicationPhase
                 {
                     Id = 4,
                     Description = "CEO Final Interview"
                 },
                 new ApplicationPhase
                 {
                     Id = 5,
                     Description = "Offer Sent"
                 }
            );
        }
    }
}