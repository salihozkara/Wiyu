using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Blockchain.Blazor.WebAssembly;

[DependsOn(
    typeof(BlockchainBlazorModule),
    typeof(BlockchainHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class BlockchainBlazorWebAssemblyModule : AbpModule
{

}
