using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using AbpLearnIncludeZero.Configuration;
using AbpLearnIncludeZero.EntityFramework;

namespace AbpLearnIncludeZero.Migrator
{
    [DependsOn(typeof(AbpLearnIncludeZeroEntityFrameworkModule))]
    public class AbpLearnIncludeZeroMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpLearnIncludeZeroMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(AbpLearnIncludeZeroMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<AbpLearnIncludeZeroDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                AbpLearnIncludeZeroConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}