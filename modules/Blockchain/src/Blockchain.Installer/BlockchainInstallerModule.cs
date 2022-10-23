using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Blockchain;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class BlockchainInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<BlockchainInstallerModule>();
        });
    }
}
