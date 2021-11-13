using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    public class PowerPlantDetailDto
    {
        public string Name { get; set; }
        public double Usage { get; set; }
        public double Capacity { get; set; }
        public AddressDto Address { get; set; }
    }
}
