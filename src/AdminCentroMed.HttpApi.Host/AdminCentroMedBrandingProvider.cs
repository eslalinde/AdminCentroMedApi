using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AdminCentroMed;

[Dependency(ReplaceServices = true)]
public class AdminCentroMedBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AdminCentroMed";
}
