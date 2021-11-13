using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.Wards;
using Developmenthub.SmartMetering.Wards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties
{
    public interface IWardAppService : IApplicationService
    {
        Task<WardDto> CreateAsync(WardDto wardDto);
        Task<ListWardsDto> GetAsync(Guid reserviorId);
        Task<ListResultDto<ListWardsDto>> GetAllAsync();
        Task<WardDto> UpdateAsync(CreateUpdateWardDto input);
        Task DeleteAsync(Guid wardId);
        Task AssignWard(WardZoneDto wardZone);
    }
}
