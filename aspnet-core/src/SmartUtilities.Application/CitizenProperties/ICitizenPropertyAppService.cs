using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartUtilities.CitizenProperties.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.CitizenProperties
{
    public interface ICitizenPropertyAppService: IApplicationService
    {
        Task<CitizenPropertyDto> CreateAsync(CreatePropertyDto property);
        Task<CitizenPropertyDto> GetAsync(Guid id);
        Task<ListResultDto<ListPropertyDto>> GetAllAsync();
        Task<CitizenPropertyDto> UpdateAsync(CitizenPropertyDto input);
        Task<CitizenPropertyDto> SearchErf(string erfnumber);
    }
}
