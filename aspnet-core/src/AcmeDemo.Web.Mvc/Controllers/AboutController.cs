using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AcmeDemo.Controllers;

namespace AcmeDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AcmeDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
