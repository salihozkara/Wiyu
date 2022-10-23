using Volo.Abp.Reflection;

namespace Blockchain.Permissions;

public class BlockchainPermissions
{
    public const string GroupName = "Blockchain";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(BlockchainPermissions));
    }
}
