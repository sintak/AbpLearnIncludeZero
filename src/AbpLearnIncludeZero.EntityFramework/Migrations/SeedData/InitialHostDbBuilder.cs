using AbpLearnIncludeZero.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AbpLearnIncludeZero.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AbpLearnIncludeZeroDbContext _context;

        public InitialHostDbBuilder(AbpLearnIncludeZeroDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
