using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartUtilities.Configuration;

namespace SmartUtilities.Web.Host.Startup
{
    [DependsOn(
       typeof(SmartUtilitiesWebCoreModule))]
    public class SmartUtilitiesWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SmartUtilitiesWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartUtilitiesWebHostModule).GetAssembly());
        }
    }
}
