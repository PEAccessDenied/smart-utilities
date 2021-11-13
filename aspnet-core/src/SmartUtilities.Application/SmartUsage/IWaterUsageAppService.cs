using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.SmartUsage.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage
{
    public interface IWaterUsageAppService
    {
        Task<WaterUsageDto> CreateAsync(WaterUsageDto input);
        Task<WaterUsageDto> GetAsync(Guid id);
        Task<ListResultDto<ListWaterUsage>> GetAllAsync();
        Task Delete(WaterUsageDeleteDto input);
        Task<WaterUsageDto> UpdateAsync(UpdateWaterUsageDto input);
    }
}
