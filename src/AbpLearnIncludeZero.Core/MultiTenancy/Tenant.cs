using Abp.MultiTenancy;
using AbpLearnIncludeZero.Users;

namespace AbpLearnIncludeZero.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}