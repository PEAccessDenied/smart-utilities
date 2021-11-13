using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Developmenthub.SmartMetering.ServiceWards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Wards.Dto
{
    [AutoMapFrom(typeof(ServiceWard))]
    public class ServiceWardDto: EntityDto<Guid>
    {
        public double ServiceRate { get; set; }
    }
}
