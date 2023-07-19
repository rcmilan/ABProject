using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABProject.Data;

/* This is used if database provider does't define
 * IABProjectDbSchemaMigrator implementation.
 */
public class NullABProjectDbSchemaMigrator : IABProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
