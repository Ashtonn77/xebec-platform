using System;

namespace XebecPortal.Client.JobPortalTestEnv.Models
{
    public class JobSampleTestV2 : JobSampleTest
    {
        public enum JobPlatform
        { LinkedIn, Twitter, Indeed }

        public DateTime CreationDate { get; set; }
    }
}