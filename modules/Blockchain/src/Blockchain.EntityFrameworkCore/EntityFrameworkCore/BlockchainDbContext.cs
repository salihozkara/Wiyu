using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Blockchain.EntityFrameworkCore;

[ConnectionStringName(BlockchainDbProperties.ConnectionStringName)]
public class BlockchainDbContext : AbpDbContext<BlockchainDbContext>, IBlockchainDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public BlockchainDbContext(DbContextOptions<BlockchainDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureBlockchain();
    }
}
