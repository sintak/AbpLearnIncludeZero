using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace AbpLearnIncludeZero.EntityFramework
{
    [DependsOn(
        typeof(AbpLearnIncludeZeroCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class AbpLearnIncludeZeroEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AbpLearnIncludeZeroDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}