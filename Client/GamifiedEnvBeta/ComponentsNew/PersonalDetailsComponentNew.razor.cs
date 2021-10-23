using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;
using XebecPortal.Shared.NewGamifiedModels;

namespace XebecPortal.Client.GamifiedEnvBeta.ComponentsNew
{
    public partial class PersonalDetailsComponentNew
    {
        public PersonalTestInfo PersonalInfo { get; set; } = new PersonalTestInfo();

        // This handles changes to the Gender drop box.
        [Parameter]
        public EventCallback<string> GenderChanged
        {
            get;
            set;
        }
        //This task handles any changes to the Gender drop box (received by GenderChanged).
        private Task OnGenderChanged(ChangeEventArgs e)
        {
            //e is the new drop box option
            PersonalInfo.Gender = e.Value.ToString();
            return GenderChanged.InvokeAsync(PersonalInfo.Gender);
        }

        /*
    * Html <option>'s values are string
    * the below code will allow us to accept boolean values from the disability drop down
    * Yes - true
    * No - false
    */
        [Parameter]
        public EventCallback<bool> DisabilityChanged
        {
            get;
            set;
        }

        private Task OnDisabilityChanged(ChangeEventArgs e)
        {
            PersonalInfo.Disability = Convert.ToBoolean(e.Value.ToString());
            return DisabilityChanged.InvokeAsync(PersonalInfo.Disability);
        }

    }
}
