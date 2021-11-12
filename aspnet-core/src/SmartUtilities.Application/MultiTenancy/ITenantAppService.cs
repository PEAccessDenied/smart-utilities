using Abp.Application.Services;
using SmartUtilities.MultiTenancy.Dto;

namespace SmartUtilities.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

