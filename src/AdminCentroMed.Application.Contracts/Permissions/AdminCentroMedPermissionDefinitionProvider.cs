using AdminCentroMed.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AdminCentroMed.Permissions;

public class AdminCentroMedPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var masterDataGroup = context.AddGroup(AdminCentroMedPermissions.GroupName, L("Permission:MasterData"));

        var countryPermission = masterDataGroup.AddPermission(AdminCentroMedPermissions.Country.Default, L("Permission:Country"));
        countryPermission.AddChild(AdminCentroMedPermissions.Country.Create, L("Permission:Create"));
        countryPermission.AddChild(AdminCentroMedPermissions.Country.Update, L("Permission:Update"));
        countryPermission.AddChild(AdminCentroMedPermissions.Country.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AdminCentroMedResource>(name);
    }
}