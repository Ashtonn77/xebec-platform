using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace XebecPortal.Shared
{
    public class Result
    {
        public int Id { get; set; }

        public float ExpectedSalary { get; set; }

        public float StartDate { get; set; }

        public float NoticePeriodId { get; set; }

        public float LocationId { get; set; }

        public float Experience { get; set; }

        public float PermissionId { get; set; }

        public float CitizenId { get; set; }

        public float VisaId { get; set; }

        public float WorkPermitId { get; set; }

        public float University { get; set; }

        public float PlatformId { get; set; }

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public int JobId { get; set; }

        public Job Job { get; set; }
    }
}
