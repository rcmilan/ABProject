using ABProject.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ABProject.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ABProjectPageModel : AbpPageModel
{
    protected ABProjectPageModel()
    {
        LocalizationResourceType = typeof(ABProjectResource);
    }
}
