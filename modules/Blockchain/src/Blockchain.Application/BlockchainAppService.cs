using Blockchain.Localization;
using Volo.Abp.Application.Services;

namespace Blockchain;

public abstract class BlockchainAppService : ApplicationService
{
    protected BlockchainAppService()
    {
        LocalizationResource = typeof(BlockchainResource);
        ObjectMapperContext = typeof(BlockchainApplicationModule);
    }
}
