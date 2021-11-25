using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;

namespace XebecPortal.Client.JobPortalTestEnv.Services
{
    public class MockCandidateDataService : IPersonalInformationDataService
    {
        private List<PersonalInformation> _personalInformations;
        private List<Status> _countries;
        private List<ApplicationPhase> _applicationPhases;

        private IEnumerable<PersonalInformation> PersonalInformations
        {
            get
            {
                if (_personalInformations == null)
                    InitializePersonalInformations();
                return _personalInformations;
            }
        }

        private List<Status> Statuses
        {
            get
            {
                if (_countries == null)
                    InitializeCountries();
                return _countries;
            }
        }

        private List<ApplicationPhase> JobCategories
        {
            get
            {
                if (_applicationPhases == null)
                    InitializeJobCategories();
                return _applicationPhases;
            }
        }

        public PersonalInformation SavedPersonalInformation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void InitializeJobCategories()
        {
            _applicationPhases = new List<ApplicationPhase>()
            {
                new ApplicationPhase{Id = 1, Description = "Applied"},
                new ApplicationPhase{Id = 2, Description = "Code Submission"},
                new ApplicationPhase{Id = 3, Description = "Interview"},
                new ApplicationPhase{Id = 4, Description = "Hiring"},
            };
        }

        private void InitializeCountries()
        {
            _countries = new List<Status>
            {
                new Status {Id = 1, Description = "Accepted"},
                new Status {Id = 2, Description = "Rejected"},
                new Status {Id = 3, Description = "In Progress"},
                new Status {Id = 4, Description = "Completed"},
            };
        }

        private void InitializePersonalInformations()
        {
            if (_personalInformations == null)
            {
                PersonalInformation p1 = new PersonalInformation
                {
                    Id = 1,
                    Email = "example@mail.com",
                    FirstName = "Full",
                    LastName = "Name",

                    PhoneNumber = "324777888773",
                };
                _personalInformations = new List<PersonalInformation>() { p1 };
            }
        }

        public async Task<IEnumerable<PersonalInformation>> GetAllPersonalInformations()
        {
            return await Task.Run(() => PersonalInformations);
        }

        public async Task<List<Status>> GetAllCountries()
        {
            return await Task.Run(() => Statuses);
        }

        public async Task<List<ApplicationPhase>> GetAllJobCategories()
        {
            return await Task.Run(() => JobCategories);
        }

        public async Task<PersonalInformation> GetPersonalInformationDetails(int PersonalInformationId)
        {
            return await Task.Run(() => { return PersonalInformations.FirstOrDefault(e => e.Id == PersonalInformationId); });
        }

        public Task<PersonalInformation> AddPersonalInformation(PersonalInformation PersonalInformation)
        {
            throw new NotImplementedException();
        }

        public Task DeletePersonalInformation(int PersonalInformationId)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePersonalInformation(PersonalInformation PersonalInformation)
        {
            throw new NotImplementedException();
        }

        public Task<PersonalInformation> GetSibglePersonalInformationByUserID(int AppUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PersonalInformation>> GetPersonalInformationsByUserID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PersonalInformation> GetPersonalInfoByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}