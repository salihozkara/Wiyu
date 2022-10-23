using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blockchain.EntityFrameworkCore;

public class BlockchainHttpApiHostMigrationsDbContext : AbpDbContext<BlockchainHttpApiHostMigrationsDbContext>
{
    public BlockchainHttpApiHostMigrationsDbContext(DbContextOptions<BlockchainHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureBlockchain();
    }
}
