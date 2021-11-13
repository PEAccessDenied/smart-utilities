using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Developmenthub.SmartMetering.SmartUsage.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.SmartUsage
{
    public class GasUsageAppService : SmartMeteringAppServiceBase, IGasUsageAppService
    {

        private readonly IRepository<GasUsage, Guid> _gasUsageRepository;
        private readonly IGasUsageManager _gasUsageManager;

        public GasUsageAppService(IRepository<GasUsage, Guid> gasUsageRepository, IGasUsageManager gasUsageManager)
        {
            _gasUsageRepository = gasUsageRepository;
            _gasUsageManager = gasUsageManager;
        }

        //create
        public async Task<GasUsageDto> CreateAsync(GasUsageDto input)
        {
            var gasUsage = ObjectMapper.Map<GasUsage>(input);

            return ObjectMapper.Map<GasUsageDto>(await _gasUsageManager.CreateAsync(gasUsage));
        }

        //Delete
        public async Task Delete(GasUsageDeleteDto input)
        {
            var gasUsage = await _gasUsageRepository.FirstOrDefaultAsync(input.Id);
            if (gasUsage == null)
            {
                throw new Exception("Not usage");
            }
            await _gasUsageManager.Delete(gasUsage.Id);
        }

        //Get all
        public async Task<ListResultDto<ListGasUsageDto>> GetAllAsync()
        {
            return ObjectMapper.Map<ListResultDto<ListGasUsageDto>>(await _gasUsageManager.GetAllAsync());
        }

        //Get by ID
        public async Task<GasUsageDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<GasUsageDto>(await _gasUsageManager.GetAsync(id));
        }

        
        //Update
        public async Task<GasUsageDto> UpdateAsync(UpdateGasUsageDto input)
        {
            var gasUsage = await _gasUsageRepository.FirstOrDefaultAsync(input.Id);
            var id = gasUsage.Id;
            if (gasUsage == null)
            {
                throw new Exception("Not updated");
            }
            gasUsage.Id = id;
            return ObjectMapper.Map<GasUsageDto>(_gasUsageManager.UpdateAsync(gasUsage.Id));
        }
    }
}
