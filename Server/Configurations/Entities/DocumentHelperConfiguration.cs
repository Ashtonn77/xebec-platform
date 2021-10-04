using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class DocumentHelperConfiguration : IEntityTypeConfiguration<DocumentHelper>
    {
       
        public void Configure(EntityTypeBuilder<DocumentHelper> builder)
        {
            builder.HasData
            (
                new DocumentHelper
                {
                     Id = 1,
                     UserId =1,
                     DocumentId =1
                },
                 new DocumentHelper
                 {
                     Id = 2,
                     UserId = 1,
                     DocumentId = 2
                 }
            );
        }
    }
}