using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Blockchain;

[DependsOn(
    typeof(BlockchainApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class BlockchainHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(BlockchainApplicationContractsModule).Assembly,
            BlockchainRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BlockchainHttpApiClientModule>();
        });

    }
}
