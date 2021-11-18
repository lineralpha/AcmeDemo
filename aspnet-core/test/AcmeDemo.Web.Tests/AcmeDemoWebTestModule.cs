using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AcmeDemo.EntityFrameworkCore;
using AcmeDemo.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AcmeDemo.Web.Tests
{
    [DependsOn(
        typeof(AcmeDemoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AcmeDemoWebTestModule : AbpModule
    {
        public AcmeDemoWebTestModule(AcmeDemoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AcmeDemoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AcmeDemoWebMvcModule).Assembly);
        }
    }
}