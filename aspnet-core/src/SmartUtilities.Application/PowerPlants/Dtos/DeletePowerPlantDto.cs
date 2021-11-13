using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.CitizenProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.PowerPlants 
{ 
    public class DeletePowerPlantDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Usage { get; set; }
    }
}
