using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.UI;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.Reservoirs;
using Developmenthub.SmartMetering.Reservoirs.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Reserviors
{
    public class ReserviorAppService : SmartMeteringAppServiceBase, IReserviorAppService
    {
        private readonly IRepository<Reservior, Guid> _reservoirRepository;
        private readonly IReservoirManager _reservoirManager;
        private readonly IRepository<Address, Guid> _addressRepository;

        public ReserviorAppService(
            IRepository<Reservior, Guid> reservoirRepository, 
            IReservoirManager reservoirManager,
            IRepository<Address, Guid> addressRepository)
        {
            _reservoirRepository = reservoirRepository;
            _reservoirManager = reservoirManager;
            _addressRepository = addressRepository;
        }

        public async Task<CreateUpdateReservoirDto> CreateAsync(CreateUpdateReservoirDto input)
        {
            await CurrentUnitOfWork.SaveChangesAsync();

            var reservoir = await _reservoirManager.CreateAsync(new Reservior
            {
                ResourceCategory = input.ResourceCategory,
                ResourceName = input.ResourceName,
                ResourceType = input.ResourceType,
                Location = input.Location,
                Capacity = input.Capacity,
                Zones = input.Zones,
                SupplierId = input.SupplierId
            });
            return ObjectMapper.Map<CreateUpdateReservoirDto>(reservoir);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _reservoirManager.DeleteAsync(id);
        }

        public async Task<ListResultDto<ListReservoirDto>> GetAllAsync()
        {
            var reservoirs = await _reservoirRepository
                .GetAll()
                .Include(s => s.Supplier)
                .ToListAsync();
            //var reservoirList = ObjectMapper.Map<List<Reservior>>(reservoirs);
            return new ListResultDto<ListReservoirDto>(ObjectMapper.Map<List<ListReservoirDto>>(reservoirs));
        }

        public async Task<ListReservoirDto> GetAsync(Guid id)
        {
            var reservoir = await _reservoirRepository
                .GetAll()
                .Include(s => s.Supplier)                          
                .FirstOrDefaultAsync(r => r.Id == id);
            return ObjectMapper.Map<ListReservoirDto>(reservoir);
        }

        public async Task<CreateUpdateReservoirDto> UpdateAsync(UpdateReservoirDto input)
        {
            var reservoir = await _reservoirRepository.FirstOrDefaultAsync(input.Id);

            if (reservoir == null)
            {
                throw new UserFriendlyException("User was not updated because maybe it is deleted");
            }
            var id = input.Id;
            var mappedResult = ObjectMapper.Map(input, reservoir);
            mappedResult.Id = id;

            return ObjectMapper.Map<CreateUpdateReservoirDto>(await _reservoirManager.UpdateAsync(mappedResult));
        }
    }
}
