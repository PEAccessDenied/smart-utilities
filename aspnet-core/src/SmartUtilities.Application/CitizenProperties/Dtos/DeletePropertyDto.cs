using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.SmartUsage.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties
{
    [AutoMapTo(typeof(CitizenProperty))]
    public class DeletePropertyDto: EntityDto<Guid>
    {
        //public Address Address { get; set; }
        ////public Citizen PropertyOwner { get; set; }
        //public string ErfNo { get; set; }
        //public CreateWaterUsageDto WaterUsageDto { get; set; }
        //public CreateElectricityUsageDto ElectricityUsageDto { get; set; }

    }
}
