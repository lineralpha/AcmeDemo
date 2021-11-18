using Abp.AspNetCore.Mvc.ViewComponents;

namespace AcmeDemo.Web.Views
{
    public abstract class AcmeDemoViewComponent : AbpViewComponent
    {
        protected AcmeDemoViewComponent()
        {
            LocalizationSourceName = AcmeDemoConsts.LocalizationSourceName;
        }
    }
}
