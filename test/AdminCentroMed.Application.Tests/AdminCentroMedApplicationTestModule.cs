using Volo.Abp.Modularity;

namespace AdminCentroMed;

[DependsOn(
    typeof(AdminCentroMedApplicationModule),
    typeof(AdminCentroMedDomainTestModule)
    )]
public class AdminCentroMedApplicationTestModule : AbpModule
{

}
