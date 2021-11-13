using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.Addresses;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers.Dtos
{
    public class CreateGasPlantInput : EntityDto<Guid>
    {

        public string Name { get; set; }
        public int Capacity { get; set; }
        public AddressDto Address { get; set; }
        public Guid WardId { get; set; }
    }
}
