using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.New_Job_Board
{
    public partial class CandidateViewTable : ComponentBase
    {
        [Parameter]
        public ApplicationPhaseHelper PhaseHelper { get; set; }

        [Parameter]
        public EventCallback<ApplicationPhaseHelper> PhaseHelperChanged { get; set; }

        [Parameter]
        public DisplayInfo DisplayedInfo { get; set; }

        [Parameter]
        public EventCallback<DisplayInfo> DisplayedInfoChanged { get; set; }

        [Parameter]
        public PersonalInformation Candidate { get; set; }

        [Parameter]
        public EventCallback<PersonalInformation> CandidateInfoChanged { get; set; }

        [Parameter]
        public List<ApplicationPhaseHelper> PhaseHelpers { get; set; }

        [Parameter]
        public EventCallback<List<ApplicationPhaseHelper>> PhaseHelpersChanged { get; set; }

        [Parameter]
        public List<PersonalInformation> Candidates { get; set; }

        [Parameter]
        public IList<Status> Statuses { get; set; }

        [Parameter]
        public IList<ApplicationPhase> ApplicationPhases { get; set; }

        [Parameter]
        public Dictionary<PersonalInformation, List<ApplicationPhaseHelper>> AssociatedPhaseHelpers { get; set; }

        [Parameter]
        public bool AllLoaded { get; set; } = false;

        public List<DisplayCandidate> AllCandidates { get; set; }
        public IList<DisplayCandidate> ShownCandidates { get; set; }

        public string? SearchTerm { get; set; } = String.Empty;
        public StringBuilder status { get; set; } = new StringBuilder("loading");

        public string NoPhase { get; set; } = "no phase found for this candidate";

        [Inject]
        public IStatusDataService StatusDataService { get; set; }

        [Inject]
        public IApplicationPhaseHelperDataService ApplicationPhaseHelperDataService { get; set; }

        [Parameter]
        public int JobId { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Console.WriteLine("CandidateViewTable Component");
            Console.WriteLine("Hey Promise down Here");
            if (Candidates != null && Statuses != null && ApplicationPhases != null && AssociatedPhaseHelpers != null)
            {
                Console.WriteLine("Candidates != null && Statuses != null && ApplicationPhases != null && AssociatedPhaseHelpers != null");
                AllLoaded = true;
                AllCandidates = new List<DisplayCandidate>();

                Console.WriteLine();
                Console.WriteLine("Associating helpers to candidates");
                foreach (var helper in AssociatedPhaseHelpers)
                {
                    var tempCandidate = helper.Key;
                    var tempPhaseHelpers = helper.Value;
                    ApplicationPhase tempPhase = new ApplicationPhase();
                    Status tempStatus = new Status();

                    GetLatestStatus(tempPhaseHelpers, out tempPhase, out tempStatus);

                    DisplayCandidate candidate = new DisplayCandidate
                    {
                        CandidatesInfo = tempCandidate,
                        ApplicationPhase = tempPhase,
                        Status = tempStatus,
                        AppPhaseHelpers = tempPhaseHelpers
                    };
                    AllCandidates.Add(candidate);
                }

                ShownCandidates = AllCandidates;
            }
            else
            {
                AllLoaded = false;
            }
        }

        private void GetLatestStatus(IList<ApplicationPhaseHelper> applicationPhaseHelpers, out ApplicationPhase tempPhase, out Status tempStatus)
        {
            if (applicationPhaseHelpers != null && applicationPhaseHelpers.Count > 0)
            {
                DateTime lastestdate = applicationPhaseHelpers[0].TimeMoved;
                int pos = 0;

                for (int i = 0; i < applicationPhaseHelpers.Count; i++)
                {
                    DateTime ObservedDate = applicationPhaseHelpers[i].TimeMoved;
                    //https://docs.microsoft.com/en-us/dotnet/api/system.datetime.compare?view=net-5.0
                    if (DateTime.Compare(lastestdate, ObservedDate) < 0)
                    {
                        lastestdate = ObservedDate;
                        pos = i;
                    }
                }
                tempPhase = applicationPhaseHelpers[pos].ApplicationPhase;
                tempStatus = applicationPhaseHelpers[pos].Status;
            }
            else
            {
                tempPhase = new ApplicationPhase
                {
                    Description = "error : no associated Application Phase for user"
                };
                tempStatus = new Status
                {
                    Description = "error : no associated status for user"
                };
            }
        }

        private async Task ChangeProfileAsync(DisplayCandidate candidate)
        {
            Console.WriteLine($"Trying to change Info for {candidate.CandidatesInfo.FirstName}");
            var tempHelper = candidate.AppPhaseHelpers.Last<ApplicationPhaseHelper>();
            var tempCandidate = candidate.CandidatesInfo;
            DisplayedInfo.AppPhase = candidate.ApplicationPhase.Description;
            DisplayedInfo.Status = candidate.Status.Description;
            DisplayedInfo.Comments = tempHelper.Comments;
            DisplayedInfo.FullName = tempCandidate.FirstName + " " + tempCandidate.LastName;
            DisplayedInfo.PhoneNumber = tempCandidate.PhoneNumber;
            DisplayedInfo.Email = tempCandidate.Email;
            await DisplayedInfoChanged.InvokeAsync(DisplayedInfo);

            PhaseHelpers = AssociatedPhaseHelpers[tempCandidate];
            await PhaseHelperChanged.InvokeAsync(PhaseHelpers.Last());
            await PhaseHelpersChanged.InvokeAsync(PhaseHelpers);
        }

        private void SearchAsync()
        {
            if (string.IsNullOrEmpty(SearchTerm) || string.IsNullOrWhiteSpace(SearchTerm))
            {
                ShownCandidates = AllCandidates;
            }
            else
            {
                ShownCandidates = AllCandidates.FindAll(q =>
                    string.Equals(SearchTerm, q.CandidatesInfo.FirstName, StringComparison.OrdinalIgnoreCase) || string.Equals(SearchTerm, q.CandidatesInfo.LastName, StringComparison.OrdinalIgnoreCase));
                ShownCandidates = AllCandidates.FindAll(q => string.Equals(SearchTerm, q.ApplicationPhase.Description, StringComparison.OrdinalIgnoreCase) || string.Equals(SearchTerm, q.Status.Description, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}