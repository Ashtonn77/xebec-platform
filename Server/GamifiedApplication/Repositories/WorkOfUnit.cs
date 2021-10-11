using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace Server.GamifiedAplication
{
    public class WorkOfUnit : IWorkOfUnit
    {
        private readonly AppDbContext _context;

        private IEncompassingRepository<AppUser> _appusers;
        public WorkOfUnit(AppDbContext context)
        {
            _context = context;
        }

        public IEncompassingRepository<AppUser> AppUsers => _appusers ??= new EncompassingRepository<AppUser>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

    }
}
