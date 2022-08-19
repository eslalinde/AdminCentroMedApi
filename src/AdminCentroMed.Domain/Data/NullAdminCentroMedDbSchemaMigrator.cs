using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AdminCentroMed.Data;

/* This is used if database provider does't define
 * IAdminCentroMedDbSchemaMigrator implementation.
 */
public class NullAdminCentroMedDbSchemaMigrator : IAdminCentroMedDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
