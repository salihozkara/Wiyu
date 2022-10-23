using Blockchain.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Blockchain.Blazor.Server.Host;

public abstract class BlockchainComponentBase : AbpComponentBase
{
    protected BlockchainComponentBase()
    {
        LocalizationResource = typeof(BlockchainResource);
    }
}
