using System.Threading.Tasks;

namespace AdminCentroMed.Data;

public interface IAdminCentroMedDbSchemaMigrator
{
    Task MigrateAsync();
}
