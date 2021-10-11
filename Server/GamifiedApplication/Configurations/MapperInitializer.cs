using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using XebecPortal.Shared.Security;

namespace Server.GamifiedAplication
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {

            CreateMap<AppUser, AppUserDto>().ReverseMap();

        }

    }
}
