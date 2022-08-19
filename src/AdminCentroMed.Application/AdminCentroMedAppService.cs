using System;
using System.Collections.Generic;
using System.Text;
using AdminCentroMed.Localization;
using Volo.Abp.Application.Services;

namespace AdminCentroMed;

/* Inherit your application services from this class.
 */
public abstract class AdminCentroMedAppService : ApplicationService
{
    protected AdminCentroMedAppService()
    {
        LocalizationResource = typeof(AdminCentroMedResource);
    }
}
