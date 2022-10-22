using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Wiyu;

[Dependency(ReplaceServices = true)]
public class WiyuBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Wiyu";
}
