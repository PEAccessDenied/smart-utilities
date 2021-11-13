using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using Developmenthub.SmartMetering.Reserviors;
using Developmenthub.SmartMetering.Reservoirs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Reservoirs
{
    public interface IReserviorAppService: IApplicationService
    {
        Task<CreateUpdateReservoirDto> CreateAsync(CreateUpdateReservoirDto reservoirDto);
        Task<ListReservoirDto> GetAsync(Guid reserviorId);
        Task<ListResultDto<ListReservoirDto>> GetAllAsync();
        Task<CreateUpdateReservoirDto> UpdateAsync(UpdateReservoirDto reservoirDto);
        Task DeleteAsync(Guid reserviorId);
    }
}
