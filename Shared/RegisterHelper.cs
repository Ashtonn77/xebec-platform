using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XebecPortal.Shared
{
     public class RegisterHelper
    {
        public int Id { get; set; }
        public DateTime TimeDateOfRegistration { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
