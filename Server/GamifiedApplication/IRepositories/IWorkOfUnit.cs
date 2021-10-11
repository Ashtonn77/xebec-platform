using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace Server.GamifiedAplication
{
    public interface IWorkOfUnit : IDisposable
    {

        IEncompassingRepository<AppUser> AppUsers { get; }

        Task Save();

    }
}
