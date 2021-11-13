using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.SmartUsage.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage
{
    public interface IGasUsageAppService
    {
        Task<GasUsageDto> CreateAsync(GasUsageDto input);
        Task<GasUsageDto> GetAsync(Guid id);
        Task<ListResultDto<ListGasUsageDto>> GetAllAsync();
        Task Delete(GasUsageDeleteDto input);
        Task<GasUsageDto> UpdateAsync(UpdateGasUsageDto input);
    }
}
