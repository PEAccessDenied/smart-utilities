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
    public class WaterUsageAppService: SmartMeteringAppServiceBase, IWaterUsageAppService
    {
        private readonly IRepository<WaterUsage, Guid> _waterUsageRepository;
        private readonly IWaterUsageManager _waterManager;

        public WaterUsageAppService(IRepository<WaterUsage, Guid> waterUsageRepository, IWaterUsageManager waterManager)
        {
            _waterUsageRepository = waterUsageRepository;
            _waterManager = waterManager;
        }

        public async Task<WaterUsageDto> CreateAsync(WaterUsageDto input)
        {
            var waterUsage = ObjectMapper.Map<WaterUsage>(input);

            return ObjectMapper.Map<WaterUsageDto>(await _waterManager.CreateAsync(waterUsage));
        }

        public async Task Delete(WaterUsageDeleteDto input)
        {
            var waterUsage = await _waterUsageRepository.FirstOrDefaultAsync(input.Id);
            if (waterUsage == null)
            {
                throw new Exception("Not usage");
            }
            await _waterManager.Delete(waterUsage.Id);
        }

        public async Task<ListResultDto<ListWaterUsage>> GetAllAsync()
        {
            return ObjectMapper.Map<ListResultDto<ListWaterUsage>>(await _waterManager.GetAllAsync());
        }

        public async Task<WaterUsageDto> GetAsync(Guid id)
        {
            return  ObjectMapper.Map<WaterUsageDto>(await _waterUsageRepository.FirstOrDefaultAsync(id));
        }

        public async Task<WaterUsageDto> UpdateAsync(UpdateWaterUsageDto input)
        {
            var waterUsage = await _waterUsageRepository.FirstOrDefaultAsync(input.Id);
            var id = waterUsage.Id;
            if (waterUsage == null)
            {
                throw new Exception("Not updated");
            }
            waterUsage.Id = id;
            return ObjectMapper.Map<WaterUsageDto>(_waterManager.UpdateAsync(waterUsage.Id));
        }
    }
}
