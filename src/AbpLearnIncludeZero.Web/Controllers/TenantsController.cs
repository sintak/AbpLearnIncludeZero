using Abp.AspNetCore.Mvc.Authorization;
using AbpLearnIncludeZero.Authorization;
using AbpLearnIncludeZero.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace AbpLearnIncludeZero.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : AbpLearnIncludeZeroControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}