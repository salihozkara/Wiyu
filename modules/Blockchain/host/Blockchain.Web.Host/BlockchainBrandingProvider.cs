using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Blockchain;

[Dependency(ReplaceServices = true)]
public class BlockchainBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blockchain";
}
