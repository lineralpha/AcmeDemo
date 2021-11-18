using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AcmeDemo.Authorization;

namespace AcmeDemo
{
    [DependsOn(
        typeof(AcmeDemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AcmeDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AcmeDemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AcmeDemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
