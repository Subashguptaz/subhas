using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace subhas.Controllers
{
    public abstract class subhasControllerBase: AbpController
    {
        protected subhasControllerBase()
        {
            LocalizationSourceName = subhasConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
