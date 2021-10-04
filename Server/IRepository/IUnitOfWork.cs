using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        //Model Repositories
        IGenericRepository<AdditionalInformation> AdditionalInformation { get; }
        IGenericRepository<Application> Applications { get; }
        IGenericRepository<ApplicationPhase> Phases { get; }
        IGenericRepository<ApplicationPhaseHelper> ApplicationPhaseHelpers { get; }
        IGenericRepository<Document> Documents { get; }
        IGenericRepository<DocumentHelper> DocumentHelper { get; }
        IGenericRepository<Education> Education { get; }
        IGenericRepository<EducationHelper> EducationHelpers { get; }
        IGenericRepository<Job> Jobs { get; }
        IGenericRepository<JobType> JobTypes { get; }
        IGenericRepository<JobTypeHelper> JobTypeHelpers { get; }
        IGenericRepository<LoginHelper> LoginHelpers { get; }
        IGenericRepository<PersonalInformation> PersonalInformation { get; }
        IGenericRepository<RegisterHelper> RegisterHelpers { get; }
        IGenericRepository<Status> Statuses { get; }
        IGenericRepository<User> Users { get; }
        IGenericRepository<WorkHistory> WorkHistory { get; }
        IGenericRepository<WorkHistoryHelper> WorkHistoryHelpers { get; }

        //Saving to the DB
        Task Save();

    }
}
