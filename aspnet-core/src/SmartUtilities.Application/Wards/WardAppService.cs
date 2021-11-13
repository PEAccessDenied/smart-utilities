using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Runtime.Session;
using Developmenthub.SmartMetering.MunicipalServices;
using Developmenthub.SmartMetering.PowerPlants;
using Developmenthub.SmartMetering.Reserviors;
using Developmenthub.SmartMetering.ServiceWards;
using Developmenthub.SmartMetering.Wards.Dto;
using Developmenthub.SmartMetering.Zones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.CitizenProperties
{
    public class WardAppService : SmartMeteringAppServiceBase,  IWardAppService
    {
        private readonly IRepository<Ward, Guid> _repositoryWard;
        private readonly IRepository<Reservior, Guid> _reserviorRepository;
        private readonly IRepository<PowerPlant, Guid> _powerPlantRepository;
        private readonly IWardManager _wardManager;
        private readonly IRepository<MunicipalService, Guid> _municipalServiceRepository;
        private readonly IRepository<Zone, Guid> _zoneRepository;

        public WardAppService(IRepository<Ward, Guid> repositoryWard,
            IWardManager wardManager,
            IRepository<Reservior, Guid> reserviorRepository,
            IRepository<PowerPlant, Guid> powerPlantRepository,
            IRepository<MunicipalService, Guid> municipalServiceRepository,
            IRepository<Zone, Guid> zoneRepository)
        {
            _repositoryWard = repositoryWard;
            _wardManager = wardManager;
            _reserviorRepository = reserviorRepository;
            _powerPlantRepository = powerPlantRepository;
            _municipalServiceRepository = municipalServiceRepository;
            _zoneRepository = zoneRepository;
        }

        public async Task AssignWard(WardZoneDto wardZone)
        {
            var ward = await _repositoryWard.FirstOrDefaultAsync(w => w.Id == wardZone.WardId); 
            var zone = await _zoneRepository.FirstOrDefaultAsync(z => z.Id == wardZone.ZoneId);
            if (ward != null)
            {
                ward.ZoneId = zone.Id;
                await _repositoryWard.UpdateAsync(ward);
            }
        }

        public async Task<WardDto> CreateAsync(WardDto wardDto)
        {
            var res = await _reserviorRepository.FirstOrDefaultAsync(r => r.Id == wardDto.ReservoirId);
            var power = await _powerPlantRepository.FirstOrDefaultAsync(r => r.Id == wardDto.PowerPlantId);
            var zone = await _zoneRepository.FirstOrDefaultAsync(z => z.Id == wardDto.ZoneId);

            var ward = new Ward();

            if (res != null)
            {
                ward = new Ward
                {
                    TenantId = AbpSession.TenantId,
                    WardNo = wardDto.WardNo,
                    ReservoirId = wardDto.ReservoirId
                };
            }
            else if (power != null)
            {
                ward = new Ward
                {
                    TenantId = AbpSession.TenantId,
                    WardNo = wardDto.WardNo,
                    PowerPlantId = wardDto.PowerPlantId,
                };
            }
            else
            {
                ward = new Ward
                {
                    TenantId = AbpSession.TenantId,
                    WardNo = wardDto.WardNo,
                    Location = wardDto.Location,
                    ServiceWards = new List<ServiceWard>(wardDto.ServiceWards)
                };
            }
            var wardResult = await _repositoryWard.InsertAsync(ward);
            return ObjectMapper.Map<WardDto>(wardResult);
        }

        public async Task DeleteAsync(Guid Id)
        {
            await _wardManager.DeleteAsync(Id);
        }
        public async Task<ListResultDto<ListWardsDto>> GetAllAsync()
        {
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                var results = await _repositoryWard
                .GetAll()
                .Where(x => x.TenantId == AbpSession.GetTenantId())
                .Include(r => r.Reservior)
                .Include(p => p.PowerPlant)
                .Include(x => x.ServiceWards)
                .ThenInclude(s => s.MunicipalService)
                .Include(p => p.CitizenProperties)
                .ToListAsync();
                return new ListResultDto<ListWardsDto>(ObjectMapper.Map<List<ListWardsDto>>(results));
            }
        }

        public async Task<ListWardsDto> GetAsync(Guid wardId)
        {
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))       
            {
                var ward = await _repositoryWard
                .GetAll()
                .Where(x => x.TenantId == AbpSession.GetTenantId())
                .Include(r => r.Reservior)
                .Include(r => r.PowerPlant)
                .Include(x => x.ServiceWards)
                .ThenInclude(s => s.MunicipalService)
                .Include(p => p.CitizenProperties)
                .FirstOrDefaultAsync(w => w.Id == wardId);
                if (ward == null)
                {
                    throw new Exception("No ward with that Id!");
                }
                return ObjectMapper.Map<ListWardsDto>(ward);
            }
        }

        public async Task<WardDto> UpdateAsync(CreateUpdateWardDto wardDto)
        {
            var wardFromDB = await _repositoryWard.FirstOrDefaultAsync(wardDto.Id);

            if (wardFromDB == null)
            {
                throw new Exception("Can not update this ward");
            }
            var id = wardFromDB.Id;

            ObjectMapper.Map(wardDto, wardFromDB);

            wardFromDB.Id = id;

            return ObjectMapper.Map<WardDto>( await _repositoryWard.UpdateAsync(wardFromDB));
        }
    }
}
