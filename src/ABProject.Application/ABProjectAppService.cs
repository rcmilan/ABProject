using System;
using System.Collections.Generic;
using System.Text;
using ABProject.Localization;
using Volo.Abp.Application.Services;

namespace ABProject;

/* Inherit your application services from this class.
 */
public abstract class ABProjectAppService : ApplicationService
{
    protected ABProjectAppService()
    {
        LocalizationResource = typeof(ABProjectResource);
    }
}
