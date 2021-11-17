using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XebecPortal.Client.JobPortalTestEnv.New_Job_Board
{
    public partial class ChangeStatusForm : ComponentBase
    {
        //Inputs: 
            //Entry<PersonalDetails, List<ApplicationPhaseHelpers>> AssociatedApplicationPhaseHelper 
        //
        //Outputs:
            //Name + Last Name : PersonalDetails
            //Lastest Phase
            //New Phase
            //Save button
        //Process:
            //Get CANDIDATE Personal Info
            //Display Candidate Personal Info
        //Get Lastest (Current) ApplicationPhaseHelper
        //Display Application Status
        //
        //Save Changes
        //Send temp (new) model to db
        //

        [Parameter]
        public string Display { get; set; } = "none";

    }
}
