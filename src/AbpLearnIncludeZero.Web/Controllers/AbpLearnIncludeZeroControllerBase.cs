using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace AbpLearnIncludeZero.Web.Controllers
{
    public abstract class AbpLearnIncludeZeroControllerBase: AbpController
    {
        protected AbpLearnIncludeZeroControllerBase()
        {
            LocalizationSourceName = AbpLearnIncludeZeroConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}