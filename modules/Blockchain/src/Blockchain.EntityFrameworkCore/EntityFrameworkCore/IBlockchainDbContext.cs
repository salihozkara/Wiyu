using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Blockchain.EntityFrameworkCore;

[ConnectionStringName(BlockchainDbProperties.ConnectionStringName)]
public interface IBlockchainDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
