using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AdminCentroMed.Data;
using Volo.Abp.DependencyInjection;

namespace AdminCentroMed.EntityFrameworkCore;

public class EntityFrameworkCoreAdminCentroMedDbSchemaMigrator
    : IAdminCentroMedDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAdminCentroMedDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AdminCentroMedDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AdminCentroMedDbContext>()
            .Database
            .MigrateAsync();
    }
}
