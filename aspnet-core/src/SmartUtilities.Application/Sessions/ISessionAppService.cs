using System.Threading.Tasks;
using Abp.Application.Services;
using SmartUtilities.Sessions.Dto;

namespace SmartUtilities.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
