using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.Reserviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Reservoirs.Dtos
{
    [AutoMapFrom(typeof(Reservior))]
    public class UpdateReservoirDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public double Capacity { get; set; }
    }
}
