using ABProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABProjectController : AbpControllerBase
{
    protected ABProjectController()
    {
        LocalizationResource = typeof(ABProjectResource);
    }
}
