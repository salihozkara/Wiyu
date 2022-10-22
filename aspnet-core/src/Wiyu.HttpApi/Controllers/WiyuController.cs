using Microsoft.AspNetCore.Components;
using Wiyu.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Wiyu.Controllers;

/* Inherit your controllers from this class.
 */
[Route("api/[controller]")]
public abstract class WiyuController : AbpControllerBase
{
    protected WiyuController()
    {
        LocalizationResource = typeof(WiyuResource);
    }
}
