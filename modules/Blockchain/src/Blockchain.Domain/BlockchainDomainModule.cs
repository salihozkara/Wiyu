using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Blockchain;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(BlockchainDomainSharedModule)
)]
public class BlockchainDomainModule : AbpModule
{

}
