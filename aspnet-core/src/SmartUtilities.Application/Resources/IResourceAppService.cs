using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.Resources.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Resources
{
    public interface IResourceAppService
    {
        Task<ResourceListDto> CreateAsync(CreateResouceDto resouce);
        Task<ResourceListDto> GetAsync(Guid id);
        Task<ListResultDto<ResourceListDto>> GetAllAsync();
        Task<ListResultDto<SupplierZoneResourceListDto>> GetAllSZRLAsync();
        Task<UpdateResourceDto> UpdateAsync(UpdateResourceDto input);
        Task DeleteAsync(Guid id);
    }
}
