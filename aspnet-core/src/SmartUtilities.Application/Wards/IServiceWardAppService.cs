using Abp.Application.Services;
using Developmenthub.SmartMetering.Wards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Wards
{
    public interface IServiceWardAppService : IApplicationService
    {
        Task<ServiceWardDto> UpdateAsync(ServiceWardDto input);
    }
}
