using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.SmartUsage.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage
{
    public interface IElectricityUsageAppService
    {
        Task<ElectricityUsageDto> CreateAsync(ElectricityUsageDto input);
        Task<ElectricityUsageDto> GetAsync(Guid id);
        Task<ListResultDto<ListElectricityUsageDto>> GetAllAsync();
        Task Delete(ElectricityUsageDeleteDto input);
        Task<ElectricityUsageDto> UpdateAsync(UpdateElectricityrUsageDto input);
    }
}
