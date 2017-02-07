using Abp.Authorization;
using AbpLearnIncludeZero.Authorization.Roles;
using AbpLearnIncludeZero.MultiTenancy;
using AbpLearnIncludeZero.Users;

namespace AbpLearnIncludeZero.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
