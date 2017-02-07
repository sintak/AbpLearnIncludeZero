using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using AbpLearnIncludeZero.Authorization;

namespace AbpLearnIncludeZero
{
    [DependsOn(
        typeof(AbpLearnIncludeZeroCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpLearnIncludeZeroApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpLearnIncludeZeroAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}