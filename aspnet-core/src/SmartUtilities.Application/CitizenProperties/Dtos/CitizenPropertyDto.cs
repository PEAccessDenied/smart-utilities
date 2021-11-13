using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenPropertyUsers;
using Developmenthub.SmartMetering.SmartDevices;
using Developmenthub.SmartMetering.SmartDevices.Dtos;
using Developmenthub.SmartMetering.SmartUsage.Dtos;
using Developmenthub.SmartMetering.Users.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties.Dtos
{
    [AutoMapFrom(typeof(CitizenProperty))]
    public class CitizenPropertyDto : EntityDto<Guid>
    {

        public string ErfNo { get; set; }
        public Guid WardId { get; set; }
        public string Type { get; set; }
        public ICollection<CitizenPropertyUserDto> PropertyUsers { get; set; }
        public ICollection<SmartDeviceListDto> PropertyDevices { get; set; }
        public ICollection<UserRole> Roles { get; set; }
        public AddressDto Address { get; set; }
        public WardDto Ward { get; set; }
    }
}
