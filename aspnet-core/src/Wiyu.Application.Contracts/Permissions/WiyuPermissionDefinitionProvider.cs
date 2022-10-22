using Wiyu.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Wiyu.Permissions;

public class WiyuPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WiyuPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WiyuPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WiyuResource>(name);
    }
}
