using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.SmartDevices.Dtos;
using System;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartDevices
{
    internal interface ISmartDeviceAppAppService : IApplicationService
    {
        Task<CreateDeviceDto> CreateAsync(CreateDeviceDto input);
        Task<ListResultDto<SmartDeviceListDto>> GetAllAsync();
        Task<SmartDeviceDetailDto> GetByIdAsync(Guid Id);
        Task<SmartDeviceListDto> UpdateAsync(UpdateSmartDeviceDto supplier);
        Task DeleteAsync(SmartDeviceDeleteDto Id);
    }
}