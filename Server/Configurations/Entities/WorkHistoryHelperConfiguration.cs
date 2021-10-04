using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class WorkHistoryHelperConfiguration : IEntityTypeConfiguration<WorkHistoryHelper>
    {
       
        public void Configure(EntityTypeBuilder<WorkHistoryHelper> builder)
        {
            builder.HasData
            (
                new WorkHistoryHelper
                {
                     Id = 1,
                     UserId =1,
                     WorkHistoryId=1
                },
                 new WorkHistoryHelper
                 {
                     Id = 2,
                     UserId = 1,
                     WorkHistoryId = 2
                 }
            );
        }
    }
}