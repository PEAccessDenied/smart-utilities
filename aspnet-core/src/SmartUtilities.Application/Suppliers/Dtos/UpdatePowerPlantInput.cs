using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.PowerPlants.Dtos;
using System;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    public class UpdatePowerPlantInput : EntityDto<Guid>
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public AddressDto Address { get; set; }
        public Guid WardId { get; set; }
    }
}