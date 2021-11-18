using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AcmeDemo.Configuration;

namespace AcmeDemo.Web.Host.Startup
{
    [DependsOn(
       typeof(AcmeDemoWebCoreModule))]
    public class AcmeDemoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AcmeDemoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AcmeDemoWebHostModule).GetAssembly());
        }
    }
}
