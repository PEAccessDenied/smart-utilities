using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using SmartUtilities.Addresses;
using SmartUtilities.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties.Dtos
{
    [AutoMapFrom(typeof(CitizenProperty))]
    public class CitizenPropertyDto : EntityDto<Guid>
    {

        public string ErfNo { get; set; }
        public Guid WardId { get; set; }
        public string Type { get; set; }
        public ICollection<CitizenPropertyUserDto> PropertyUsers { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public AddressDto Address { get; set; }

        private WardDto ward;

        public WardDto GetWard()
        {
            return ward;
        }

        public void SetWard(WardDto value)
        {
            ward = value;
        }
    }
}
