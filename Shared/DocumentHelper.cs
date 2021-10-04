using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XebecPortal.Shared
{
    public class DocumentHelper
    {
        public int Id { get; set; }

        //Foreign Key: User
        public int UserId { get; set; }

        public User User { get; set; }
        //Foreign Key: Document
        public int DocumentId { get; set; }

        public Document Document { get; set; }
    }
}
