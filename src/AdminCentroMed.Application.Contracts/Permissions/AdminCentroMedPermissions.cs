namespace AdminCentroMed.Permissions;

public static class AdminCentroMedPermissions
{
    public const string GroupName = "MasterData";

    public class Country
    {
        public const string Default = GroupName + ".Country";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}