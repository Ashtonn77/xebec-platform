using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Server.GamifiedApplicationPhaseFour.Models;
using XebecPortal.Shared;
using XebecPortal.Shared.NewGamifiedDtos;
using XebecPortal.Shared.NewGamifiedModels;
using XebecPortal.Shared.Security;

namespace Server.GamifiedApplicationPhaseFour
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {

            CreateMap<AppUser, AppUserDto>().ReverseMap();
            CreateMap<EducationTest, EducationTestDto>().ReverseMap();
            CreateMap<WorkHistoryTest, WorkHistoryTestDto>().ReverseMap();
            CreateMap<PersonalTestInfo, PersonalTestDto>().ReverseMap();
            CreateMap<Document, DocumentTestDto>().ReverseMap();
            CreateMap<AdditionalInformationTest, AdditionalInformationTestDto>().ReverseMap();

        }

    }
}
