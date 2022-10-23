using Volo.Abp.Modularity;

namespace Blockchain;

[DependsOn(
    typeof(BlockchainApplicationModule),
    typeof(BlockchainDomainTestModule)
    )]
public class BlockchainApplicationTestModule : AbpModule
{

}
