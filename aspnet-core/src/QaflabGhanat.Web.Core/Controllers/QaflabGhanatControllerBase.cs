using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace QaflabGhanat.Controllers
{
    public abstract class QaflabGhanatControllerBase: AbpController
    {
        protected QaflabGhanatControllerBase()
        {
            LocalizationSourceName = QaflabGhanatConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
