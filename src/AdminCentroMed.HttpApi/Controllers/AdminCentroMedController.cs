using AdminCentroMed.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AdminCentroMed.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AdminCentroMedController : AbpControllerBase
{
    protected AdminCentroMedController()
    {
        LocalizationResource = typeof(AdminCentroMedResource);
    }
}
