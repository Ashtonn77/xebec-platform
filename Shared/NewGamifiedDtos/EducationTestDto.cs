using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace XebecPortal.Shared.NewGamifiedDtos
{
    public class EducationTestDto
    {
         public int Id { get; set; }

        public string Insitution { get; set; }

        public string Qualification { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

         public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}