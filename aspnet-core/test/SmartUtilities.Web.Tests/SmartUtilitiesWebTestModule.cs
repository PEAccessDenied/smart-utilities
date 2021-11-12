using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SmartUtilities.EntityFrameworkCore;
using SmartUtilities.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SmartUtilities.Web.Tests
{
    [DependsOn(
        typeof(SmartUtilitiesWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SmartUtilitiesWebTestModule : AbpModule
    {
        public SmartUtilitiesWebTestModule(SmartUtilitiesEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SmartUtilitiesWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SmartUtilitiesWebMvcModule).Assembly);
        }
    }
}