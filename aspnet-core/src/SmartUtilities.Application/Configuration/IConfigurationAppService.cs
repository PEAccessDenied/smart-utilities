using System.Threading.Tasks;
using SmartUtilities.Configuration.Dto;

namespace SmartUtilities.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
