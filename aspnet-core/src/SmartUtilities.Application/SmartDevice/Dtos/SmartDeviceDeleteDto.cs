using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartDevices.Dtos
{
    [AutoMapFrom(typeof(SmartDevice))]
    public class SmartDeviceDeleteDto: EntityDto<Guid>
    {
    }
}
