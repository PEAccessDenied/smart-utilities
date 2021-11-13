using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.CitizenProperties.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties
{
    public interface ICitizenPropertyAppService: IApplicationService
    {
        Task<CitizenPropertyDto> CreateAsync(CreatePropertyDto property);
        Task<CitizenPropertyDto> GetAsync(Guid id);
        Task<ListResultDto<ListPropertyDto>> GetAllAsync();
        Task<CitizenPropertyDto> UpdateAsync(CitizenPropertyDto input);
        Task DeleteAsync(DeletePropertyDto propertyId);
        Task<CitizenPropertyDto> SearchErf(string erfnumber);
    }
}
