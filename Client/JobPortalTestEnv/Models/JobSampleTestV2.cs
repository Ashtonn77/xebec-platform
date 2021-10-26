using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.Models
{
    public class JobSampleTestV2 : JobSampleTest
    {
        public enum JobPlatform { LinkedIn, Twitter, Indeed }

        public DateTime CreationDate { get; set; }
    }
}
 