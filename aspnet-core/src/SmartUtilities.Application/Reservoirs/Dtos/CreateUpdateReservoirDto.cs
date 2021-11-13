using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.Reserviors;
using Developmenthub.SmartMetering.Suppliers.Dtos;
using Developmenthub.SmartMetering.Zones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Reservoirs.Dtos
{
    [AutoMapTo(typeof(Reservior))]
    public class CreateUpdateReservoirDto
    {     
        public string ResourceCategory { get; set; }
        public string ResourceName { get; set; }
        public string ResourceType { get; set; }
        public string Location { get; set; }
        public double Capacity { get; set; }
        public ICollection<Zone> Zones { get; set; }
        public Guid SupplierId { get; set; }

    }
}
