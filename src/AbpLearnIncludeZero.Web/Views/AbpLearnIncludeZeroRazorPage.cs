using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AbpLearnIncludeZero.Web.Views
{
    public abstract class AbpLearnIncludeZeroRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpLearnIncludeZeroRazorPage()
        {
            LocalizationSourceName = AbpLearnIncludeZeroConsts.LocalizationSourceName;
        }
    }
}
