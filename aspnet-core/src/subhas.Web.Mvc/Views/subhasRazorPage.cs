using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace subhas.Web.Views
{
    public abstract class subhasRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected subhasRazorPage()
        {
            LocalizationSourceName = subhasConsts.LocalizationSourceName;
        }
    }
}
