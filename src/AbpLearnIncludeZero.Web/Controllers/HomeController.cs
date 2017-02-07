using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AbpLearnIncludeZero.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpLearnIncludeZeroControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}