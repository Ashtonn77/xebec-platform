using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class EducationHelperConfiguration : IEntityTypeConfiguration<EducationHelper>
    {
       
        public void Configure(EntityTypeBuilder<EducationHelper> builder)
        {
            builder.HasData
            (
                new EducationHelper
                {
                     Id = 1,
                     UserId =1,
                     EducationId =1
                },
                 new EducationHelper
                 {
                     Id = 2,
                     UserId = 1,
                     EducationId = 2
                 }
            );
        }
    }
}