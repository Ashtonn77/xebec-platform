using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XebecPortal.Shared
{
    public class ApplicationPhaseHelper
    {
        public int Id { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public int PhaseId { get; set; }
        public ApplicationPhase ApplicationPhase { get; set; }
        public int StatusId { get; set; }
        //public Status Status { get; set; }
        public DateTime TimeMoved { get; set; }
        public string Comments { get; set; }
    }
}
