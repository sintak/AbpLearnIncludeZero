using Microsoft.AspNetCore.Mvc;

namespace AbpLearnIncludeZero.Web.Controllers
{
    public class AboutController : AbpLearnIncludeZeroControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}