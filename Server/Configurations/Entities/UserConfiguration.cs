using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XebecPortal.Shared;

namespace Server.Configurations.Entities
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(

                new User
                {
                    Id = 1,
                    Email = "sample@gmail.com",
                    PasswordHash = "2526sgfgfhsgdf984894s",
                    Role = "Candidate"    
                },
                 new User
                 {
                     Id = 2,
                     Email = "analyst@test.com",
                     PasswordHash = "1538sgligrand9845sds",
                     Role = "Analyst"
                 }
            );
        }
    }
}