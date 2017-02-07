using System.Linq;
using AbpLearnIncludeZero.EntityFramework;
using AbpLearnIncludeZero.MultiTenancy;

namespace AbpLearnIncludeZero.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly AbpLearnIncludeZeroDbContext _context;

        public DefaultTenantCreator(AbpLearnIncludeZeroDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
