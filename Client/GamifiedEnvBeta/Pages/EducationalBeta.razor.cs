using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Client.GamifiedEnvBeta.PhaseTwo.Pages;
using XebecPortal.Client.GamifiedEnvBeta.PhaseTwo.Shared;


namespace XebecPortal.Client.GamifiedEnvBeta.Pages
{
    public partial class EducationalBeta
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
        public EducationFormP3 EducationForm = null;

        private void addNewDiv()
        {

            forms.Add(
                new RenderFragment(builder =>
                {
                    builder.OpenComponent<EducationFormP3>(0);
                    builder.AddComponentReferenceCapture(0, inst => { EducationForm = (EducationFormP3)inst; });
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
