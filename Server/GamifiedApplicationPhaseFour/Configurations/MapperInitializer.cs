using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Server.GamifiedApplicationPhaseFour.Models;
using XebecPortal.Shared.Security;

namespace Server.GamifiedApplicationPhaseFour
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {

            CreateMap<AppUser, AppUserDto>().ReverseMap();

        }

    }
}
