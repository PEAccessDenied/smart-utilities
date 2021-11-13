using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.CitizenPropertyUsers;
using Developmenthub.SmartMetering.SmartUsage;
using Developmenthub.SmartMetering.Users.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties
{
    [AutoMapFrom(typeof(CitizenProperty))]
    public class ListPropertyDto : FullAuditedEntityDto<Guid>
    {
        public string Type { get; set; }
        public ICollection<CitizenPropertyUserDto> PropertyUsers { get; set; }
        public AddressDto Address { get; set; }
        public string ErfNo { get; set; }
        public int Consumption { get; set; }
    }
}
