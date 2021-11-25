using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.New_Job_Board
{
    public partial class CandidateProfile : ComponentBase
    {
        [Parameter]
        public DisplayInfo DisplayedInfo { get; set; }

        [Parameter]
        public List<ApplicationPhaseHelper> PhaseHelpers { get; set; }

        [Parameter]
        public EventCallback<List<ApplicationPhaseHelper>> PhaseHelpersChanged { get; set; }

        [Parameter]
        public ApplicationPhaseHelper PhaseHelper { get; set; }

        [Parameter]
        public EventCallback<ApplicationPhaseHelper> PhaseHelperChanged { get; set; }

        [Parameter]
        public List<Status> statuses { get; set; }

        [Parameter]
        public List<ApplicationPhase> applicationPhases { get; set; }

        [Parameter]
        public PersonalInformation Candidate { get; set; }

        [Parameter]
        public Dictionary<PersonalInformation, List<ApplicationPhaseHelper>> AssociatedPhaseHelpers { get; set; } = new Dictionary<PersonalInformation, List<ApplicationPhaseHelper>>();

        public IEnumerable<Status> Statuses { get; set; }
        public IEnumerable<ApplicationPhase> ApplicationPhases { get; set; }

        private ApplicationPhaseHelper TempPhaseHelper { get; set; }

        [Inject]
        private IApplicationPhaseHelperDataService PhaseHelperDataService { get; set; }

        [Inject]
        private IStatusDataService StatusDataService { get; set; }

        [Inject]
        private IApplicationPhaseDataService ApplicationPhaseDataService { get; set; }

        [Parameter]
        public int JobId { get; set; }

        [Inject]
        public IJobDataService JobDataService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Statuses = await StatusDataService.GetAllStatuses();
            ApplicationPhases = await ApplicationPhaseDataService.GetAllApplicationPhases();

            if (PhaseHelpers != null)
            {
                Console.WriteLine();
                Console.WriteLine("Phase helpers are not null");
                PhaseHelper = PhaseHelpers.Last<ApplicationPhaseHelper>();
                await PhaseHelperChanged.InvokeAsync(PhaseHelper);
            }
            await base.OnInitializedAsync();
        }

        public string PopUpDisplay { get; set; }

        private string popupDisplay = "none";

        private void ShowPopUp()
        {
            Console.WriteLine("Showing pop Up");
            Console.WriteLine($"Current Phase Helper {PhaseHelper}");
            List<ApplicationPhaseHelper> tempHelpers = new List<ApplicationPhaseHelper>();
            if (AssociatedPhaseHelpers != null && Candidate != null)
            {
                Console.WriteLine("AssociatedPhaseHelpers != null && Candidate != null");
                tempHelpers = AssociatedPhaseHelpers[Candidate];
            }
            else
            {
                Console.WriteLine("AssociatedPhaseHelpers == null && Candidate == null");
                Console.WriteLine("Sleeping");
                System.Threading.Thread.Sleep(2000);
                if (AssociatedPhaseHelpers != null && Candidate != null)
                {
                    tempHelpers = AssociatedPhaseHelpers[Candidate];
                    if (tempHelpers != null)
                    {
                        PhaseHelper = tempHelpers.Last<ApplicationPhaseHelper>();
                    }
                    else
                    {
                        PhaseHelper = new ApplicationPhaseHelper
                        {
                            Id = 90287635,
                            Status = new Status { Description = " Error", Id = 3 },
                            ApplicationPhase = new ApplicationPhase { Description = "Error", Id = 3 }
                        };
                    }
                }
            }

            popupDisplay = "block";
        }

        private void ClosePopUp()
        {
            popupDisplay = "none";
        }

        public async Task Save()
        {
            await httpClient.PutAsJsonAsync($"api/ApplicationPhaseHelper/{PhaseHelper.Id}", PhaseHelper);
            ClosePopUp();
            Console.WriteLine("Sending Data");
        }

        public string Message { get; set; } = "";
        public bool Saved { get; set; } = false;

        protected async Task HandleValidSubmit()
        {
            await PhaseHelperChanged.InvokeAsync(PhaseHelper);

            Message = "Saving";
            Console.WriteLine(Message);
            if (PhaseHelper != null)
            {
                Console.WriteLine("Phase Helper is not null");
                ApplicationPhaseHelper temp = new ApplicationPhaseHelper
                {
                    ApplicationId = PhaseHelper.Id,

                    StatusId = PhaseHelper.StatusId,

                    ApplicationPhaseId = PhaseHelper.ApplicationPhaseId,
                    TimeMoved = DateTime.Now,
                    Comments = PhaseHelper.Comments
                };

                await PhaseHelperDataService.UpdateApplicationPhaseHelper(PhaseHelper.Id, PhaseHelper);
                //var ApplicationHelperDTO = new StringContent(JsonSerializer.Serialize(PhaseHelper), Encoding.UTF8, "application/json");
                //var response = await httpClient.PutAsync("api/ApplicationPhaseHelper", ApplicationHelperDTO);
                //ApplicationPhaseHelper responseContent = new ApplicationPhaseHelper();
                //if (response.IsSuccessStatusCode)
                //{
                //    responseContent = await JsonSerializer.DeserializeAsync<ApplicationPhaseHelper>(await response.Content.ReadAsStreamAsync());
                //}

                //Message = $"User successfully. {response}";
                Console.WriteLine(Message);
                Saved = true;
            }

            Thread.Sleep(3000);
            ClosePopUp();
        }
    }
}