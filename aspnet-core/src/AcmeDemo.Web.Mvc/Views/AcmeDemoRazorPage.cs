using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AcmeDemo.Web.Views
{
    public abstract class AcmeDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AcmeDemoRazorPage()
        {
            LocalizationSourceName = AcmeDemoConsts.LocalizationSourceName;
        }
    }
}
