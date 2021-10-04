using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XebecPortal.Shared
{
    public class EducationHelper
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int EducationId { get; set; }

        public Education Education { get; set; }
    }
}
