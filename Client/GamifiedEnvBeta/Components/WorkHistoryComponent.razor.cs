using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XebecPortal.Client.GamifiedEnvBeta.Components
{
    public partial class WorkHistoryComponent
    {
        private async Task OnAfterRenderAsync()

        {
            await JS.InvokeVoidAsync("addDiv"); // Can be removed. We are using c# now (not javascript).
        }
        //This stores a list of components (WorkHistoryForms) to render
        List<RenderFragment> forms = new List<RenderFragment>();

        private const string WorkHistoryFormstr = "<WorkHistoryFormComponent />"; //Not being used

        //This represents the component being rendered (or added by the addNewDiv method).
        public WorkHistoryFormComponent WorkHistoryForm = null;
        private void addNewDiv()
        {

            forms.Add(
                new RenderFragment(builder =>
                {
                    builder.OpenComponent<WorkHistoryFormComponent>(0);
                    builder.AddComponentReferenceCapture(0, inst => { WorkHistoryForm = (WorkHistoryFormComponent)inst; });
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
