using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Client.GamifiedApplicationTestEnv.Shared;

namespace XebecPortal.Client.GamifiedApplicationTestEnv.PhaseTwo.Pages
{
    public partial class WorkHistoryPageP3
    {
        private async Task OnAfterRenderAsync()

        {
            await JS.InvokeVoidAsync("addDiv"); // Can be removed. We are using c# now (not javascript).
        }
        //This stores a list of components (WorkHistoryForms) to render
        List<RenderFragment> forms = new List<RenderFragment>();

        private const string WorkHistoryFormstr = "<WorkHistoryForm />"; //Not being used

        //This represents the component being rendered (or added by the addNewDiv method).
        public WorkHistoryForm WorkHistoryForm = null;
        private void addNewDiv()
        {

            forms.Add(
                new RenderFragment(builder =>
                {
                    builder.OpenComponent<WorkHistoryForm>(0);
                    builder.AddComponentReferenceCapture(0, inst => { WorkHistoryForm = (WorkHistoryForm)inst; });
                    builder.CloseComponent();

                })
            );
        }

        //Removes a razor component

        private void removeDiv(int index)
        {

            if (index < forms.Count)
            {
                forms.RemoveAt(index);
            }

        }

    }
}
