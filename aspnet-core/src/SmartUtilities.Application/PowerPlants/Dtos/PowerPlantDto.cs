using Abp.Application.Services.Dto;
using SmartUtilities.Addresses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.PowerPlants
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
