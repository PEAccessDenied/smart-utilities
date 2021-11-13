using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.SmartUsage.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage
{
    public class ElectricityUsageAppService: SmartMeteringAppServiceBase, IElectricityUsageAppService
    {
        private readonly IRepository<ElectricityUsage, Guid> _electricityUsageRepository;
        private readonly IElectricityUsageManager _electricityUsageManager;

        public ElectricityUsageAppService(IRepository<ElectricityUsage, Guid> electricityUsageRepository, IElectricityUsageManager electricityUsageManager)
        {
            _electricityUsageRepository = electricityUsageRepository;
            _electricityUsageManager = electricityUsageManager;
        }

        public async Task<ElectricityUsageDto> CreateAsync(ElectricityUsageDto input)
        {
            var electricityUsage = ObjectMapper.Map<ElectricityUsage>(input);

            return ObjectMapper.Map<ElectricityUsageDto>(await _electricityUsageManager.CreateAsync(electricityUsage));
        }

        public async Task Delete(ElectricityUsageDeleteDto input)
        {
            var electricityUsage = await _electricityUsageRepository.FirstOrDefaultAsync(input.Id);
            if (electricityUsage == null)
            {
                throw new Exception("Not usage");
            }
            await _electricityUsageManager.Delete(electricityUsage.Id);
        }

        public async Task<ListResultDto<ListElectricityUsageDto>> GetAllAsync()
        {
            return ObjectMapper.Map<ListResultDto<ListElectricityUsageDto>>(await _electricityUsageManager.GetAllAsync());
        }

        public async Task<ElectricityUsageDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<ElectricityUsageDto>(await _electricityUsageManager.GetAsync(id));
        }

        public async Task<ElectricityUsageDto> UpdateAsync(UpdateElectricityrUsageDto input)
        {
            var electricityUsage = await _electricityUsageRepository.FirstOrDefaultAsync(input.Id);
            var id = electricityUsage.Id;
            if (electricityUsage == null)
            {
                throw new Exception("Not updated");
            }
            electricityUsage.Id = id;
            return ObjectMapper.Map<ElectricityUsageDto>(_electricityUsageManager.UpdateAsync(electricityUsage.Id));
        }
    }
}
