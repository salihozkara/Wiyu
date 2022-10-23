using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Blockchain.EntityFrameworkCore;

public class BlockchainHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BlockchainHttpApiHostMigrationsDbContext>
{
    public BlockchainHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BlockchainHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Blockchain"));

        return new BlockchainHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
