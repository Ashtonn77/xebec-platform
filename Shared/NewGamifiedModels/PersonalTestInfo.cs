using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace XebecPortal.Shared.NewGamifiedModels
{
    public class PersonalTestInfo
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string IdNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public bool Disability { get; set; }

        public string Gender { get; set; }

        public string Ethnicity { get; set; }

        //foreign key
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

    }
}