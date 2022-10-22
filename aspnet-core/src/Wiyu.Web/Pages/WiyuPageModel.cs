using Wiyu.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Wiyu.Web.Pages;

public abstract class WiyuPageModel : AbpPageModel
{
    protected WiyuPageModel()
    {
        LocalizationResourceType = typeof(WiyuResource);
    }
}
