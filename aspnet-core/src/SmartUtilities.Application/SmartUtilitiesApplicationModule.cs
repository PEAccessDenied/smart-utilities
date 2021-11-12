using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartUtilities.Authorization;

namespace SmartUtilities
{
    [DependsOn(
        typeof(SmartUtilitiesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SmartUtilitiesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SmartUtilitiesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SmartUtilitiesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
