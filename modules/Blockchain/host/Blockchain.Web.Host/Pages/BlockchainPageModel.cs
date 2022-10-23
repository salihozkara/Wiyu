using Blockchain.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Blockchain.Pages;

public abstract class BlockchainPageModel : AbpPageModel
{
    protected BlockchainPageModel()
    {
        LocalizationResourceType = typeof(BlockchainResource);
    }
}
