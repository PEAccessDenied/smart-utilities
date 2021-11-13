using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    public  class CreatePowerPlantInput
    {
        public string Name { get; set; }
        public double Capacity { get; set; }
        public AddressDto Address { get; set; }
        //public Guid WardId { get; set; }
    }
}
