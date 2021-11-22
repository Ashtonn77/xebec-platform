using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XebecPortal.Client.Data_Analytics_Tool.Candidate_Analytics
{
    public partial class IdealCandidate : ComponentBase
    {
        [Parameter]
        public int DepartmentId { get; set; }
        [Parameter]
        public int JobId { get; set; }
    }
}
