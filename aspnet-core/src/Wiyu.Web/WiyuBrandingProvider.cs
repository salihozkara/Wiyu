using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Wiyu.Web;

[Dependency(ReplaceServices = true)]
public class WiyuBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Wiyu";
}
