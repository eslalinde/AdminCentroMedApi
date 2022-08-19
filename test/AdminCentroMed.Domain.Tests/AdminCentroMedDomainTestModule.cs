using AdminCentroMed.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AdminCentroMed;

[DependsOn(
    typeof(AdminCentroMedEntityFrameworkCoreTestModule)
    )]
public class AdminCentroMedDomainTestModule : AbpModule
{

}
