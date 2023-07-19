using Volo.Abp.Modularity;

namespace ABProject;

[DependsOn(
    typeof(ABProjectApplicationModule),
    typeof(ABProjectDomainTestModule)
    )]
public class ABProjectApplicationTestModule : AbpModule
{

}
