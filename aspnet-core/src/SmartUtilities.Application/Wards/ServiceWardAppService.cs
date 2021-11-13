using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.UI;
using Developmenthub.SmartMetering.ServiceWards;
using Developmenthub.SmartMetering.Wards.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Wards
{
    public class ServiceWardAppService : SmartMeteringAppServiceBase, IServiceWardAppService
    {
        private readonly IRepository<ServiceWard, Guid> _serviceWard;

        public ServiceWardAppService(IRepository<ServiceWard, Guid> serviceWard)
        {
            _serviceWard = serviceWard;
        }

        public async Task<ServiceWardDto> UpdateAsync(ServiceWardDto input)
        {
            using (CurrentUnitOfWork.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                var service = await _serviceWard.FirstOrDefaultAsync(x => x.Id == input.Id);
                if (service == null)
                {
                    throw new UserFriendlyException("No service ward was found");
                }

                var id = input.Id;
                ObjectMapper.Map(input, service);
                service.Id = id;
                return ObjectMapper.Map<ServiceWardDto>(await _serviceWard.UpdateAsync(service));
            }
        }
    }
}
