using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using Developmenthub.SmartMetering.Suppliers.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.PowerPlants
{
    public class PowerPlantDto
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double Usage { get; set; }
        public AddressDto Address { get; set; }
        public Guid WardId { get; set; }
    }
}
