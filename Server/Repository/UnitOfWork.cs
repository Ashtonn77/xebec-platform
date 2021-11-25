using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Data;
using Server.IRepository;
using XebecPortal.Shared.NewGamifiedModels;
using XebecPortal.Shared;
using XebecPortal.Shared.Security;

namespace Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        /*Authentication*/
        private IGenericRepository<AppUser> _appusers;
        /*Authentication*/

        private readonly ApplicationDbContext _context;

        private IGenericRepository<Application> _applications;
        private IGenericRepository<AdditionalInformation> _additionalInfo;
        private IGenericRepository<ApplicationPhase> _appPhases;
        private IGenericRepository<ApplicationPhaseHelper> _appPhaseHelper;
        private IGenericRepository<Document> _document;
      
        private IGenericRepository<Education> _education;
  
        private IGenericRepository<Job> _jobs;
        private IGenericRepository<JobType> _jobtypes;
        private IGenericRepository<JobTypeHelper> _jobTypeHelpers;
        private IGenericRepository<LoginHelper> _LoginHelpers;
        private IGenericRepository<PersonalInformation> _personalInfo;
        private IGenericRepository<RegisterHelper> _RegisterHelpers;
        private IGenericRepository<Status> _statuses;
        
        private IGenericRepository<WorkHistory> _workHistories;

        /*newly added*/
        private IGenericRepository<PersonalTestInfo> _personalTestInfos;
        private IGenericRepository<EducationTest> _educationTests;
        private IGenericRepository<WorkHistoryTest> _workHistoryTests;
        private IGenericRepository<AdditionalInformationTest> _additionalInformationTests;
        /*newly added*/

        //Added new repository
        private IGenericRepository<JobPlatform> _jobPlatforms;
        private IGenericRepository<JobPlatformHelper> _jobPlatformHelpers;

        //Newly Added(Kian) 
        private IGenericRepository<ProfilePortfolioLink> _profilePortfolioLinks;

        //New Tables
        private IGenericRepository<Citizenship> _citizenships;

        private IGenericRepository<Department> _departments;

        private IGenericRepository<IdealCandidate> _idealCandidates;

        private IGenericRepository<Location> _locations;

        private IGenericRepository<NoticePeriod> _noticePeriods;

        private IGenericRepository<Permission> _permissions;

        private IGenericRepository<Questionnaire> _questionnaires;

        private IGenericRepository<Result> _results;

        private IGenericRepository<Visa> _visas;

        private IGenericRepository<WorkPermit> _workPermits;


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<AdditionalInformation> AdditionalInformation => _additionalInfo ??= new GenericRepository<AdditionalInformation>(_context);

        public IGenericRepository<Application> Applications => _applications ??= new GenericRepository<Application>(_context);

        public IGenericRepository<ApplicationPhase> Phases => _appPhases ??= new GenericRepository<ApplicationPhase>(_context);

        public IGenericRepository<ApplicationPhaseHelper> ApplicationPhaseHelpers => _appPhaseHelper ??= new GenericRepository<ApplicationPhaseHelper>(_context);

        public IGenericRepository<Document> Documents => _document ??= new GenericRepository<Document>(_context);

  
        public IGenericRepository<Education> Education => _education ??= new GenericRepository<Education>(_context);


        public IGenericRepository<Job> Jobs => _jobs ??= new GenericRepository<Job>(_context);

        public IGenericRepository<JobType> JobTypes => _jobtypes ??= new GenericRepository<JobType>(_context);

        public IGenericRepository<JobTypeHelper> JobTypeHelpers => _jobTypeHelpers ??= new GenericRepository<JobTypeHelper>(_context);

        public IGenericRepository<LoginHelper> LoginHelpers => _LoginHelpers ??= new GenericRepository<LoginHelper>(_context);

        public IGenericRepository<PersonalInformation> PersonalInformation => _personalInfo ??= new GenericRepository<PersonalInformation>(_context);

        public IGenericRepository<RegisterHelper> RegisterHelpers => _RegisterHelpers ??= new GenericRepository<RegisterHelper>(_context);

        public IGenericRepository<Status> Statuses => _statuses ??= new GenericRepository<Status>(_context);
        public IGenericRepository<WorkHistory> WorkHistory => _workHistories ??= new GenericRepository<WorkHistory>(_context);

        public IGenericRepository<AppUser> AppUsers => _appusers ??= new GenericRepository<AppUser>(_context);


        public IGenericRepository<PersonalTestInfo> PersonalTestInfos => _personalTestInfos ??= new GenericRepository<PersonalTestInfo>(_context);

        public IGenericRepository<EducationTest> EducationTests => _educationTests ??= new GenericRepository<EducationTest>(_context);

        public IGenericRepository<WorkHistoryTest> WorkHistoryTests => _workHistoryTests ??= new GenericRepository<WorkHistoryTest>(_context);

        public IGenericRepository<AdditionalInformationTest> AdditionalInformationTests => _additionalInformationTests ??= new GenericRepository<AdditionalInformationTest>(_context);

        public IGenericRepository<JobPlatform> JobPlatforms => _jobPlatforms ??= new GenericRepository<JobPlatform>(_context);

        public IGenericRepository<JobPlatformHelper> JobPlatformHelpers => _jobPlatformHelpers ??= new GenericRepository<JobPlatformHelper>(_context);

        public IGenericRepository<ProfilePortfolioLink> ProfilePortfolioLinks => _profilePortfolioLinks??= new GenericRepository<ProfilePortfolioLink>(_context);

        //New tables
        public IGenericRepository<Citizenship> Citizenships => _citizenships ??= new GenericRepository<Citizenship>(_context);

        public IGenericRepository<Department> Departments => _departments ??= new GenericRepository<Department>(_context);

        public IGenericRepository<IdealCandidate> IdealCandidates => _idealCandidates ??= new GenericRepository<IdealCandidate>(_context);

        public IGenericRepository<Location> Locations => _locations ??= new GenericRepository<Location>(_context);

        public IGenericRepository<NoticePeriod> NoticePeriods => _noticePeriods ??= new GenericRepository<NoticePeriod>(_context);

        public IGenericRepository<Permission> Permissions => _permissions ??= new GenericRepository<Permission>(_context);

        public IGenericRepository<Questionnaire> Questnionnaires => _questionnaires ??= new GenericRepository<Questionnaire>(_context);

        public IGenericRepository<Result> Results => _results ??= new GenericRepository<Result>(_context);

        public IGenericRepository<Visa> Visas => _visas ??= new GenericRepository<Visa>(_context);

        public IGenericRepository<WorkPermit> WorkPermits => _workPermits ??= new GenericRepository<WorkPermit>(_context);

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
