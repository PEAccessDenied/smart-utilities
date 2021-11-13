using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Developmenthub.SmartMetering.CitizenProperties;
using Developmenthub.SmartMetering.Suppliers.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Developmenthub.SmartMetering.Suppliers
{
    public interface ISupplierAppService : IApplicationService
    {
        Task<SupplierDetailDto> CreateAsync(CreateSupplierInput input);
        Task<ListResultDto<SupplierListDto>> GetAllAsync();
        Task<SupplierDetailDto> GetByIdAsync(Guid Id);
        Task<SupplierListDto> UpdateAsync(UpdateSupplierDto supplier);
        Task DeleteAsync(Guid Id);
    }
}