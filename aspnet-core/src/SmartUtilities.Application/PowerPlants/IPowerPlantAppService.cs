using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.PowerPlants
{
    public interface IPowerPlantAppService : IApplicationService
    {
        Task<CreateUpdatePowerPlantDto> CreateAsync(CreateUpdatePowerPlantDto powerPlant);
        Task<ListPowerPlantDto> GetByIdAsync(Guid id);
        Task<ListResultDto<ListPowerPlantDto>> GetAllAsync();
        Task DeleteAsync(Guid propertyId);
    }
}
