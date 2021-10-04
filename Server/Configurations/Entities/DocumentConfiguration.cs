using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
       
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasData
            (
                new Document
                {
                     Id = 1,
                     DocumentName = "CV",
                     DocumentUrl = "https://johnsnowsociety.org"

                },
                new Document
                {
                    Id = 2,
                    DocumentName = "Drivers license",
                    DocumentUrl = "https://johnsnowdrivers.com"

                }
            );
        }
    }
}