using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class AdditionalInformationConfiguration : IEntityTypeConfiguration<AdditionalInformation>
    {
        public void Configure(EntityTypeBuilder<AdditionalInformation> builder)
        {
            builder.HasData(

                new AdditionalInformation
                {
                    Id = 1,
                    GitHubLink = $"https://github.com/johnsnowwygot",
                    LinkedInLink = $"https://linkedIn.com/snowy",
                    PersonalWebsiteUrl = $"https://jphnsnow.com ",
                    UserId = 1

                }

            );
        }
    }
}