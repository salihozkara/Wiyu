using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Blockchain.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class BlockchainBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Blockchain";
}
