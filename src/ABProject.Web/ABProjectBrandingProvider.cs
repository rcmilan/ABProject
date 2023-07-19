using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ABProject.Web;

[Dependency(ReplaceServices = true)]
public class ABProjectBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABProject";
}
