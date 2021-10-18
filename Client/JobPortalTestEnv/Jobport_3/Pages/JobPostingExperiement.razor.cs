using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.Jobport_3.Pages
{
    public partial class JobPostingExperiement
    {
         List<Job> Jobs = new List<Job>

{

            new Job
            {
                Id = 1,
                Title = "Manager",
                Description = "blah blah blah blah blah",
                Location = "Durban",
                Compensation = "R15000"



            },


             new Job
            {
                Id = 2,
                Title = "Intern",
                Description = "blah blah blah blah blah",
                Location = "Cape Town",
                Compensation = "R10000"
            },

                new Job
            {
                Id = 3,
                Title = "Director",
                Description = "blah blah blah blah blah",
                Location = "Sandton",
                Compensation = "R40000",

            },
              new Job
            {
                Id = 4,
                Title = "Intern",
                Description = "blah blah blah blah blah",
                Location = "Durban",
                Compensation = "R50000"
            },
              new Job
            {
                Id = 5,
                Title = "Manager",
                Description = "blah blah blah blah blah",
                Location = "Cape Town",
                Compensation = "R100000"
            },

    };
    }
}
