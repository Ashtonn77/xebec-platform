using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace XebecPortal.Shared.NewGamifiedDtos
{
    public class AdditionalInformationTestDto
    {
        public int Id { get; set; }

        public string GitHubLink { get; set; }

        public string LinkedInLink { get; set; }

        public string FacebookLink { get; set; }

        public string PersonalWebsiteUrl { get; set; }

        //foreign key
        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}