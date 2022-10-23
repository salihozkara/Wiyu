using Blockchain.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Blockchain;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(BlockchainEntityFrameworkCoreTestModule)
    )]
public class BlockchainDomainTestModule : AbpModule
{

}
