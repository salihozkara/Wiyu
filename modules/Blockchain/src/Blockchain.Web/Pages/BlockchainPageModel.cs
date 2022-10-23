using Blockchain.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Blockchain.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BlockchainPageModel : AbpPageModel
{
    protected BlockchainPageModel()
    {
        LocalizationResourceType = typeof(BlockchainResource);
        ObjectMapperContext = typeof(BlockchainWebModule);
    }
}
