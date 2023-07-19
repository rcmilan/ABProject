using System.Threading.Tasks;

namespace ABProject.Data;

public interface IABProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
