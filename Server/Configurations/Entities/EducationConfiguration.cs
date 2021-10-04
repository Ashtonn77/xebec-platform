using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
       
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasData
            (
                new Education
                {
                     Id = 1,
                     Insitution = "Richmond",
                     StartDate = DateTime.Now.AddSeconds(2),
                     EndDate = DateTime.Now.AddMonths(2),
                     Qualification = "BSc Computer Science"

                },
                new Education
                {
                    Id = 2,
                    Insitution = "Hogwarts",
                    StartDate = DateTime.Now.AddMinutes(2),
                    EndDate = DateTime.Now.AddMonths(14),
                    Qualification = "HighSchool Diploma"
                }
            );
        }
    }
}