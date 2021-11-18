using System.Collections.Generic;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.New_Job_Board
{
    public class DisplayCandidate
    {
        public PersonalInformation CandidatesInfo { get; set; }

        public Status Status { get; set; }

        public ApplicationPhase ApplicationPhase { get; set; }
        public List<ApplicationPhaseHelper> AppPhaseHelpers { get; set; }
    }
}