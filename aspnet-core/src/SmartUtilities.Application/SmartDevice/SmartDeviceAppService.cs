using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Developmenthub.SmartMetering.SmartDevices.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartDevices
{
    public class SmartDeviceAppService : SmartMeteringAppServiceBase, ISmartDeviceAppAppService
    {
        private readonly IRepository<SmartDevice, Guid> _deviceRepository;
        private readonly ISmartDeviceManager _deviceManager;

        public SmartDeviceAppService(IRepository<SmartDevice, Guid> deviceRepository, ISmartDeviceManager deviceManager)
        {
            _deviceRepository = deviceRepository;
            _deviceManager = deviceManager;
        }

        public async Task<CreateDeviceDto> CreateAsync(CreateDeviceDto input)
        {
            var device = new SmartDevice
            {
               Name = input.Name,
               ModelNumber = input.ModelNumber,
               SerialNumber = input.SerialNumber,
               MeterNumber = input.MeterNumber,
               MeterModelNumber = input.MeterModelNumber,
               MeterSerialNumber = input.MeterSerialNumber,
               PropertyId = input.PropertyId,
               DeviceType = input.DeviceType
            };
            await _deviceManager.CreateAsync(device);

            return ObjectMapper.Map<CreateDeviceDto>(device);
        }

        public async Task<ListResultDto<SmartDeviceListDto>> GetAllAsync()
        {
            var results = await _deviceRepository.GetAll().ToListAsync();
            return new ListResultDto<SmartDeviceListDto>(ObjectMapper.Map<List<SmartDeviceListDto>>(results));
        }

        public async Task<SmartDeviceDetailDto> GetByIdAsync(Guid Id)
        {
            var results = await _deviceRepository.GetAll().FirstOrDefaultAsync(s => s.Id == Id);
            return ObjectMapper.Map<SmartDeviceDetailDto>(results);
        }

        public async Task<SmartDeviceListDto> UpdateAsync(UpdateSmartDeviceDto input)
        {
            var deviceFromDb = await _deviceRepository.FirstOrDefaultAsync(input.Id);

            var results = new SmartDeviceListDto();

            if (deviceFromDb != null)
            {
                var id = input.Id;
                var mappedResult = ObjectMapper.Map(input, deviceFromDb);
                mappedResult.Id = id;

                results = ObjectMapper.Map<SmartDeviceListDto>(await _deviceRepository.UpdateAsync(mappedResult));
            }
            return results;
        }

        public async Task DeleteAsync(SmartDeviceDeleteDto input)
        {
            await _deviceRepository.DeleteAsync(input.Id);
        }
    }
}
