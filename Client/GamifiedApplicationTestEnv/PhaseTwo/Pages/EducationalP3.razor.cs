using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Client.GamifiedApplicationTestEnv.Shared;

namespace XebecPortal.Client.GamifiedApplicationTestEnv.PhaseTwo.Pages
{
    public partial class EducationalP3
    {
        /*
* The logic here is the same as the one in WorkHistoryPage.
* Removing and add components works the same way
*/
        private async Task OnAfterRenderAsync()

        {
            await JS.InvokeVoidAsync("addDiv");
        }

        List<RenderFragment> forms = new List<RenderFragment>();

        private const string EducationFormstr = "<EducationForm />"; //
        public EducationForm EducationForm = null;

        private void addNewDiv()
        {

            forms.Add(
                new RenderFragment(builder =>
                {
                    builder.OpenComponent<EducationForm>(0);
                    builder.AddComponentReferenceCapture(0, inst => { EducationForm = (EducationForm)inst; });
                    builder.CloseComponent();
                })
            );
        }
        private void removeDiv(int index)
        {

            if (index < forms.Count)
            {
                forms.RemoveAt(index);
            }

        }
    }
}
