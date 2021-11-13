using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.ServiceWards;
using Developmenthub.SmartMetering.Zones.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Wards.Dto
{
    [AutoMapFrom(typeof(Ward))]

    public class ListWardsDto: EntityDto<Guid>
    {
        public ICollection<AddressDto> AddressDto { get; set; }
        //public ICollection<ListPropertyDto> CitizenProperty { get; set; }
        public int PropertyCount { get; set; }
        public int Consumption { get; set; }
        public int WardNo { get; set; }
        public ZoneDto Zone { get; set; }
        public ICollection<ServiceWard> ServiceWards { get; set; }
        public string Location { get; set; }
    }
}
