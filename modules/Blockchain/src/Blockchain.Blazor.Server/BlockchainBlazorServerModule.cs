using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Blockchain.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(BlockchainBlazorModule)
    )]
public class BlockchainBlazorServerModule : AbpModule
{

}
