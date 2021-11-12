using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SmartUtilities.Controllers
{
    public abstract class SmartUtilitiesControllerBase: AbpController
    {
        protected SmartUtilitiesControllerBase()
        {
            LocalizationSourceName = SmartUtilitiesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
