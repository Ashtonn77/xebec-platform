using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XebecPortal.Shared
{
    public class AdditionalInformation
    {
        public int Id { get; set; }

        public string GitHubLink { get; set; }

        public string LinkedInLink { get; set; }

        public string FacebookLink { get; set; }

        public string PersonalWebsiteUrl { get; set; }

        //foreign key
        public int UserId { get; set; }

        public User User { get; set; }

    }
}