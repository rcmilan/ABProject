using ABProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABProjectEntityFrameworkCoreModule),
    typeof(ABProjectApplicationContractsModule)
    )]
public class ABProjectDbMigratorModule : AbpModule
{
}
