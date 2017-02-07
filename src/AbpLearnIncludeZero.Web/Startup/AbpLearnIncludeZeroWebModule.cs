using System.Reflection;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using AbpLearnIncludeZero.Configuration;
using AbpLearnIncludeZero.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Zero.Configuration;

namespace AbpLearnIncludeZero.Web.Startup
{
    [DependsOn(
        typeof(AbpLearnIncludeZeroApplicationModule), 
        typeof(AbpLearnIncludeZeroEntityFrameworkModule), 
        typeof(AbpAspNetCoreModule))]
    public class AbpLearnIncludeZeroWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public AbpLearnIncludeZeroWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(AbpLearnIncludeZeroConsts.ConnectionStringName);

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Navigation.Providers.Add<AbpLearnIncludeZeroNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(AbpLearnIncludeZeroApplicationModule).Assembly
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}