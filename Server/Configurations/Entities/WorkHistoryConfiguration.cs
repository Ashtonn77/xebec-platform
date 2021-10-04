using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class WorkHistoryConfiguration : IEntityTypeConfiguration<WorkHistory>
    {
       
        public void Configure(EntityTypeBuilder<WorkHistory> builder)
        {
            builder.HasData
            (
                new WorkHistory
                {
                     Id = 1,
                     Description = "Commanded an army to victory",
                     StartDate = DateTime.Now,
                     EndDate = DateTime.Now.AddYears(2),
                     CompanyName = "White Wolf Inc",
                     JobTitle = "Commander"
                },
                 new WorkHistory
                 {
                     Id = 2,
                     Description = "Daydreaming on a Sunday afternoon",
                     StartDate = DateTime.Now.AddYears(1),
                     EndDate = DateTime.Now.AddYears(3),
                     CompanyName = "Westeros Pty Ltd",
                     JobTitle = "King"
                 }
            );
        }
    }
}