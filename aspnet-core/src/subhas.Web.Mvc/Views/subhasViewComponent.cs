using Abp.AspNetCore.Mvc.ViewComponents;

namespace subhas.Web.Views
{
    public abstract class subhasViewComponent : AbpViewComponent
    {
        protected subhasViewComponent()
        {
            LocalizationSourceName = subhasConsts.LocalizationSourceName;
        }
    }
}
