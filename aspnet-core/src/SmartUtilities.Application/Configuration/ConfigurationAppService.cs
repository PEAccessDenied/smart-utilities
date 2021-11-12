using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SmartUtilities.Configuration.Dto;

namespace SmartUtilities.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SmartUtilitiesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
