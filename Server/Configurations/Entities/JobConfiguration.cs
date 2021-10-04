using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
       
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasData
            (
                new Job
                {
                     Id = 1,
                     Title = "Developer",
                     Description = "blah! blah! blah!",
                     Location = "JHB",
                     Compensation = "R45000",
                     Department = "IT",
                     DueDate = DateTime.Now.AddMonths(2),
                     CreationDate = DateTime.Now

                },
                new Job
                {
                    Id = 2,
                    Title = "Mobile Administrator",
                    Description = "beep! beep beep!",
                    Location = "DBN",
                    Compensation = "R50000",
                    Department = "IT",
                    DueDate = DateTime.Now.AddMonths(1),
                    CreationDate = DateTime.Now

                }
            );
        }
    }
}