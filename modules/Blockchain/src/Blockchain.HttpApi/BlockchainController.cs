using Blockchain.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Blockchain;

public abstract class BlockchainController : AbpControllerBase
{
    protected BlockchainController()
    {
        LocalizationResource = typeof(BlockchainResource);
    }
}
