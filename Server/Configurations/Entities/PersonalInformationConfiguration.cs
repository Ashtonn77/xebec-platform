using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class PersonalInformationConfiguration : IEntityTypeConfiguration<PersonalInformation>
    {
        public void Configure(EntityTypeBuilder<PersonalInformation> builder)
        {
            builder.HasData(

                new PersonalInformation
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Snow",
                    PhoneNumber = "0329434578",
                    IdNumber = "74102589631",
                    Address = "2 Winter Fell Road",
                    Disability = false,
                    Gender = "male",
                    Ethnicity = "Wildling",
                    UserId = 1

                }

            );
        }
    }
}