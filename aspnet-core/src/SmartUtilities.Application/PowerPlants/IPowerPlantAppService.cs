using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using Developmenthub.SmartMetering.PowerPlants.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.PowerPlants
{
    public interface IPowerPlantAppService : IApplicationService
    {
        Task<CreateUpdatePowerPlantDto> CreateAsync(CreateUpdatePowerPlantDto powerPlant);
        Task<ListPowerPlantDto> GetByIdAsync(Guid id);
        Task<ListResultDto<ListPowerPlantDto>> GetAllAsync();
        Task<CreateUpdatePowerPlantDto> UpdateAsync(UpdatePowerPlantDto powerPlant);
        Task DeleteAsync(Guid propertyId);
    }
}
