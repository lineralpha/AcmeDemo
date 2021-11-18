using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AcmeDemo.Controllers
{
    public abstract class AcmeDemoControllerBase: AbpController
    {
        protected AcmeDemoControllerBase()
        {
            LocalizationSourceName = AcmeDemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
