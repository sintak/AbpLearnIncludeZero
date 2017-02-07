using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using AbpLearnIncludeZero.Authorization;
using AbpLearnIncludeZero.Users;
using Microsoft.AspNetCore.Mvc;

namespace AbpLearnIncludeZero.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : AbpLearnIncludeZeroControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}