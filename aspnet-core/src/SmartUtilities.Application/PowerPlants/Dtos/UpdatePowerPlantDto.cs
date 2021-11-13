using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.PowerPlants.Dtos
{
    [AutoMapFrom(typeof(PowerPlant))]
    public class UpdatePowerPlantDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public double Capacity { get; set; }
    }
}
