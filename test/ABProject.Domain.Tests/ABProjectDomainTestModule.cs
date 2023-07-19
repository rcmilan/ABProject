using ABProject.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABProject;

[DependsOn(
    typeof(ABProjectEntityFrameworkCoreTestModule)
    )]
public class ABProjectDomainTestModule : AbpModule
{

}
