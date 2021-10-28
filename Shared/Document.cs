using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace XebecPortal.Shared
{
   public class Document
    {
        public int Id { get; set; }

        public string DocumentName { get; set; }

        public string DocumentUrl { get; set; }

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
