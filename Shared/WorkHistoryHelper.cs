using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XebecPortal.Shared
{
   public class WorkHistoryHelper
    {
        public int Id { get; set; }

        //foreign key
        public int UserId { get; set; }
        public User User{ get; set; }
        //foreign key
        public  int WorkHistoryId { get; set; }

        public WorkHistory WorkHistory { get; set; }
    }
}
