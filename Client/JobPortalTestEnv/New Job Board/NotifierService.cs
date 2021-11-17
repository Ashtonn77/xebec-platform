using System;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.New_Job_Board
{
    public class NotifierService
    {
        public NotifierService()
        {

        }

        ApplicationPhaseHelper helper;
        public ApplicationPhaseHelper PhaseHelper
        {
            get => PhaseHelper;
            set
            {
                if (PhaseHelper != value)
                {
                    PhaseHelper = value;

                    if (Notify != null)
                    {
                        Notify?.Invoke();
                    }
                }
            }
        }
        public event Func<Task> Notify;
    }
}
