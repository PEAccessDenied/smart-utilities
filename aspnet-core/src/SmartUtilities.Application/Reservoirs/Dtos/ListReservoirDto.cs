using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.Reserviors;
using Developmenthub.SmartMetering.Suppliers.Dtos;
using Developmenthub.SmartMetering.Zones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Reservoirs
{
    [AutoMapTo(typeof(Reservior))]
    public class ListReservoirDto: EntityDto<Guid>
    {
        public string ResourceCategory { get; set; }
        public string ResourceName { get; set; }
        public string ResourceType { get; set; }
        public string Location { get; set; }
        public double Capacity { get; set; }
        public ICollection<Zone> Zones { get; set; }
    }
}
