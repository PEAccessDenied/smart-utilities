using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using SmartUtilities.Addresses;
using SmartUtilities.Powerplants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartUtilities.PowerPlants
{
    public class PowerPlantAppService : SmartUtilitiesAppServiceBase, IPowerPlantAppService
    {
        private readonly IRepository<PowerPlant, Guid> _powerPlantRepository;
        private readonly IRepository<Address, Guid> _addressRepository;

        public PowerPlantAppService(
            IRepository<PowerPlant, Guid> powerPlantRepository, 
            IRepository<Address, Guid> addressRepository)
        {
            _powerPlantRepository = powerPlantRepository;
            _addressRepository = addressRepository;
        }

        public async Task<CreateUpdatePowerPlantDto> CreateAsync(CreateUpdatePowerPlantDto input)
        {
            //var wardId = input.Wards.FirstOrDefault();

            var address = ObjectMapper.Map<Address>(input.Address);
            var addressId = await _addressRepository.InsertAndGetIdAsync(address);
            await CurrentUnitOfWork.SaveChangesAsync();

            var powerPlant = await _powerPlantRepository.InsertAsync(new PowerPlant
            {
                Name = input.Name,
                SupplierId = input.SupplierId,
                AddressId = addressId,
                Capacity = input.Capacity
            });
            return ObjectMapper.Map<CreateUpdatePowerPlantDto>(powerPlant);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _powerPlantRepository.DeleteAsync(id);
        }

        public async Task<ListResultDto<ListPowerPlantDto>> GetAllAsync()
        {
            var powerPlants = await _powerPlantRepository
                .GetAll()
                .Include(s => s.Supplier)
                .Include(w => w.Wards)
                .Include(a => a.Address)
                .ToListAsync();
            return new ListResultDto<ListPowerPlantDto>(ObjectMapper.Map<List<ListPowerPlantDto>>(powerPlants));
        }

        public async Task<ListPowerPlantDto> GetByIdAsync(Guid id)
        {
            var powerPlant = await _powerPlantRepository
                .GetAll()
                .Include(s => s.Supplier)
                .Include(w => w.Wards)
                .Include(a => a.Address)
                .FirstOrDefaultAsync(r => r.Id == id);
            return ObjectMapper.Map<ListPowerPlantDto>(powerPlant);
        }

        //public async Task<CreateUpdatePowerPlantDto> UpdateAsync(UpdatePowerPlantDto input)
        //{
        //    var powerPlant = await _powerPlantRepository.FirstOrDefaultAsync(input.Id);

        //    if (powerPlant == null)
        //    {
        //        throw new UserFriendlyException("User was not updated because maybe it is deleted");
        //    }
        //    var id = input.Id;
        //    var mappedResult = ObjectMapper.Map(input, powerPlant);
        //    mappedResult.Id = id;

        //    return ObjectMapper.Map<CreateUpdatePowerPlantDto>(await _powerPlantManager.UpdateAsync(mappedResult));
        //}
    }
}
