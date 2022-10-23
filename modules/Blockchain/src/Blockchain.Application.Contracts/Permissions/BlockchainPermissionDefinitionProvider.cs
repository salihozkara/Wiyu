using Blockchain.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Blockchain.Permissions;

public class BlockchainPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BlockchainPermissions.GroupName, L("Permission:Blockchain"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BlockchainResource>(name);
    }
}
