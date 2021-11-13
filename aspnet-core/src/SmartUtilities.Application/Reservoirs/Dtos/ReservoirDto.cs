using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.Zones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Reservoirs.Dtos
{
    public class ReservoirDto : EntityDto<Guid>
    {
        public string ResourceCategory { get; set; }
        public string ResourceName { get; set; }
        public string ResourceType { get; set; }
        public string Location { get; set; }
        public double Capacity { get; set; }
        public ICollection<Zone> Zones { get; set; }
    }
}
