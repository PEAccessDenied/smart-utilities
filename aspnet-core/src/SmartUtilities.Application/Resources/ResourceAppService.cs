using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.UI;
using Developmenthub.SmartMetering.Resources.Dtos;
using Developmenthub.SmartMetering.SupplierZoneResources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Resources
{
    public class ResourceAppService : SmartMeteringAppServiceBase, IResourceAppService
    {
        private readonly IRepository<Resource, Guid> _repositoryResource;
        private readonly IRepository<SupplierZoneResource, Guid> _repositorySupplierZoneResource;
        private readonly IResourceManager _resourceManager;

        public ResourceAppService(IRepository<SupplierZoneResource, Guid> repositorySupplierZoneResource, IRepository<Resource, Guid> repositoryResource, IResourceManager resourceManager)
        {
            _repositorySupplierZoneResource = repositorySupplierZoneResource;
            _repositoryResource = repositoryResource;
            _resourceManager = resourceManager;
        }
        public async Task<ResourceListDto> CreateAsync(CreateResouceDto resouceinput)
        {
            var resource = ObjectMapper.Map<Resource>(resouceinput);
            resource.TenantId = AbpSession.TenantId;
            resource = await _repositoryResource.InsertAsync(resource);
            if (resource != null)
            {
                foreach (var zoneId in resouceinput.ZoneIds)
                {
                    var supplierZoneResource = new SupplierZoneResource();
                    supplierZoneResource.ZoneId = zoneId;
                    supplierZoneResource.ResourceId = resource.Id;
                    await _repositorySupplierZoneResource.InsertAsync(supplierZoneResource);
                }
            }
            return ObjectMapper.Map<ResourceListDto>(resource);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _resourceManager.DeleteAsync(id);
        }

        public async Task<ListResultDto<ResourceListDto>> GetAllAsync()
        {
            List<Resource> resource = new List<Resource>();
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                resource = await _repositoryResource
                              .GetAll()
                              //.Include(p => p.Supplier)
                              .Include(a => a.SupplierZoneResources)
                              .ThenInclude(b => b.Zone)
                              .ThenInclude(b => b.Wards)
                              .ToListAsync();
            }

            //var reservoirList = ObjectMapper.Map<List<Reservior>>(reservoirs);
            return new ListResultDto<ResourceListDto>(ObjectMapper.Map<List<ResourceListDto>>(resource));
        }
       

        public async Task<ListResultDto<SupplierZoneResourceListDto>> GetAllSZRLAsync()
        {
            List<SupplierZoneResource> SupplierZoneResource = new List<SupplierZoneResource>();
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                SupplierZoneResource = await _repositorySupplierZoneResource
                              .GetAll()                                                         
                              .Include(b => b.Zone)
                              .ThenInclude(b => b.Wards)
                              .ToListAsync();
            }

            //var reservoirList = ObjectMapper.Map<List<Reservior>>(reservoirs);
            return new ListResultDto<SupplierZoneResourceListDto>(ObjectMapper.Map<List<SupplierZoneResourceListDto>>(SupplierZoneResource));
        }

        public async Task<ResourceListDto> GetAsync(Guid id)
        {
            Resource resourceFromDB = new Resource();
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                resourceFromDB = await _repositoryResource
                 .GetAll()
                 //.Include(p => p.Supplier)
                 .Include(a => a.SupplierZoneResources)
                 .ThenInclude(b => b.Zone)
                 .FirstOrDefaultAsync(x => x.Id == id);
            }
            //var incidentFromDB = await _incidentManager.GetByIdAsync(Id); 
            return ObjectMapper.Map<ResourceListDto>(resourceFromDB);
        }

        public async Task<UpdateResourceDto> UpdateAsync(UpdateResourceDto input)
        {
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                var resourceFromDB = await _repositoryResource.FirstOrDefaultAsync(x => x.Id == input.Id);

                if (resourceFromDB == null)
                {
                    throw new UserFriendlyException("Incident Could Not Be Found!");
                }
                var id = input.Id;
                ObjectMapper.Map(input, resourceFromDB);
                resourceFromDB.Id = id;

                return ObjectMapper.Map<UpdateResourceDto>(await _resourceManager.UpdateAsync(resourceFromDB));
            }
            
        }
    }
}
