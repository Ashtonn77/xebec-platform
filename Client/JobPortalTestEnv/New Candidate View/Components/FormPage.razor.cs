using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.New_Candidate_View.Components
{
    public partial class FormPage : ComponentBase
    {
        public bool ShowDialog { get; set; }

        public PersonalInformation PersonalInformation { get; set; } = new PersonalInformation { Id = 1, AppUserId = 1 };

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        [Inject]
        public IPersonalInformationDataService PersonalInformationDataService { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            PersonalInformation = new PersonalInformation { Id = 1, AppUserId = 1 };
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            await PersonalInformationDataService.AddPersonalInformation(PersonalInformation);
            ShowDialog = false;

            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}