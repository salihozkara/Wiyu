using System;
using System.Collections.Generic;
using System.Text;
using Wiyu.Localization;
using Volo.Abp.Application.Services;

namespace Wiyu;

/* Inherit your application services from this class.
 */
public abstract class WiyuAppService : ApplicationService
{
    protected WiyuAppService()
    {
        LocalizationResource = typeof(WiyuResource);
    }
}
