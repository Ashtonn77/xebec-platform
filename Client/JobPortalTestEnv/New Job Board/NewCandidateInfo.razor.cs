using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.New_Job_Board
{
    public partial class NewCandidateInfo : ComponentBase
    {
        [Inject] private ILogger<NewCandidateInfo> _logger { get; set; }

        [Parameter]
        public PersonalInformation Candidate { get; set; }

        [Parameter]
        public EventCallback<PersonalInformation> CandidateInfoChanged { get; set; }

        [Parameter]
        public string JobId { get; set; }

        [Parameter] public string Title { get; set; }

        private List<PersonalInformation> RealCandidatesInfo { get; set; }
        private List<ApplicationPhase> applicationPhases { get; set; }
        private List<Status> statuses { get; set; }
        public Dictionary<PersonalInformation, List<ApplicationPhaseHelper>> AssociatedPhaseHelpers { get; set; } = new Dictionary<PersonalInformation, List<ApplicationPhaseHelper>>();
        public bool AllLoaded { get; set; } = false;

        [Parameter]
        public DisplayInfo DisplayedInfo { get; set; }

        public EventCallback<DisplayInfo> DisplayedInfoChanged { get; set; }

        [Parameter]

        public List<ApplicationPhaseHelper> PhaseHelpers { get; set; }

        public EventCallback<List<ApplicationPhaseHelper>> PhaseHelpersChanged { get; set; }
        public StringBuilder Status { get; set; } = new StringBuilder("loading");
        public ApplicationPhaseHelper CurrentPhase { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            try
            {
                applicationPhases = await httpClient.GetFromJsonAsync<List<ApplicationPhase>>("api/ApplicationPhase");
                statuses = await httpClient.GetFromJsonAsync<List<Status>>("api/Status");
                RealCandidatesInfo =
                   await httpClient.GetFromJsonAsync<List<PersonalInformation>>($"api/PersonalInformation/candidates/{int.Parse(JobId)}");
                if (RealCandidatesInfo != null)
                {
                    Status = new StringBuilder("we have all candidates now");
                    Console.WriteLine(Status.ToString());
                    foreach (var candidate in RealCandidatesInfo)
                    {
                        Status = new StringBuilder($"Getting #{candidate.AppUserId} ApplicationPhaseHelpers  ");
                        Console.WriteLine(Status.ToString());
                        var list = await httpClient.GetFromJsonAsync<List<ApplicationPhaseHelper>>(
                            $"api/ApplicationPhaseHelper/appPhase?AppUserId={candidate.AppUserId}&jobId={int.Parse(JobId)}");
                        AssociatedPhaseHelpers.Add(candidate, list);
                    }
                    Console.WriteLine();
                    Status = new StringBuilder("Done getting  ApplicationPhaseHelpers");
                    Console.WriteLine(Status.ToString());
                }

                if (applicationPhases != null && RealCandidatesInfo != null && statuses != null && AssociatedPhaseHelpers != null )
                {
                    if (AssociatedPhaseHelpers.Count > 0)
                    {
                        var entry = AssociatedPhaseHelpers.First();
                        PhaseHelpers = entry.Value;
                        if (entry.Key != null && entry.Value != null && entry.Value.Count > 0)
                        {
                            var tempHelper = entry.Value[0];
                            DisplayedInfo = new DisplayInfo
                            {
                                FullName = entry.Key.FirstName + " " + entry.Key.LastName,
                                Comments = tempHelper.Comments,
                                AppPhase = tempHelper.ApplicationPhase.Description,
                                Status = tempHelper.Status.Description,
                                PhoneNumber = entry.Key.PhoneNumber,
                                Email = entry.Key.Email
                            };
                        }
                    }
                    AllLoaded = true;
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void ChangeProfile(PersonalInformation candidate, List<ApplicationPhaseHelper> helpers)
        {
            ApplicationPhaseHelper tempHelper = helpers.Last<ApplicationPhaseHelper>();
            DisplayInfo tempDisplayInfo = new DisplayInfo
            {
                FullName = candidate.FirstName + " " + candidate.LastName,
                Comments = tempHelper.Comments,
                AppPhase = tempHelper.ApplicationPhase.Description,
                Status = tempHelper.Status.Description,
                PhoneNumber = candidate.PhoneNumber,
                Email = candidate.Email
            };

            DisplayedInfo = tempDisplayInfo;
            PhaseHelpers = helpers;
            CurrentPhase = tempHelper;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await jsRuntime.InvokeVoidAsync("initalizeSlideOutNav");
            }
        }

        private async Task ShowMenu()
        {
            await jsRuntime.InvokeVoidAsync("openNav");
        }

        private async Task CloseMenu()
        {
            await jsRuntime.InvokeVoidAsync("closeNav");
        }
    }

    public class DisplayInfo
    {
        public string FullName { get; set; }
        public string JobApplied { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public string AppPhase { get; set; }
        public string Status { get; set; }
    }
}