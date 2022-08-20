using AdminCentroMed.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AdminCentroMed.Permissions;

public class AdminCentroMedPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AdminCentroMedPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AdminCentroMedPermissions.MyPermission1, L("Permission:MyPermission1"));

        var countryPermission = myGroup.AddPermission(AdminCentroMedPermissions.Country.Default, L("Permission:Country"));
        countryPermission.AddChild(AdminCentroMedPermissions.Country.Create, L("Permission:Create"));
        countryPermission.AddChild(AdminCentroMedPermissions.Country.Update, L("Permission:Update"));
        countryPermission.AddChild(AdminCentroMedPermissions.Country.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AdminCentroMedResource>(name);
    }
}
