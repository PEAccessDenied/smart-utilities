using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.CitizenProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Reservoirs.Dtos
{
    class DeleteReservoirDto: EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        //public ICollection<WaterUsage> Volume { get; set; }
        //public ICollection<Ward> Wards { get; set; }
    }
}
