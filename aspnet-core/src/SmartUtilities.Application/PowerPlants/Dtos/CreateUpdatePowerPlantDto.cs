using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.PowerPlants.Dtos;
using Developmenthub.SmartMetering.Suppliers.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.PowerPlants
{
    [AutoMapFrom(typeof(PowerPlant))]
    public class CreateUpdatePowerPlantDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Capacity { get; set; }
        public AddressDto Address { get; set; }
        public Guid SupplierId { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }
    }
}
