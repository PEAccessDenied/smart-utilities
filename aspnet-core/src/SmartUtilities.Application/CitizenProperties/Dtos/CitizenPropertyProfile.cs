using AutoMapper;
using SmartUtilities.Assets;
using SmartUtilities.Authorization.Users;
using SmartUtilities.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties.Dtos
{
    public class CitizenPropertyProfile : Profile
    {
        public CitizenPropertyProfile()
        {
            CreateMap<ListPropertyDto, CitizenProperty>();
            //CreateMap<ListPropertyDto, CitizenProperty>()
            //    .ForMember(x => x.PropertyUsers, opt => opt.Ignore())
                //.ForMember(x => x.Address, opt => opt.Ignore());
            CreateMap<User, UserDto>();
        }
    }
}
