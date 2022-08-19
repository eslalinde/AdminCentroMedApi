using AdminCentroMed.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AdminCentroMed.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AdminCentroMedEntityFrameworkCoreModule),
    typeof(AdminCentroMedApplicationContractsModule)
    )]
public class AdminCentroMedDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
