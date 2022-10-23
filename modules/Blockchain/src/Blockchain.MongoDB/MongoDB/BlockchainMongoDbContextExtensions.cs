using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Blockchain.MongoDB;

public static class BlockchainMongoDbContextExtensions
{
    public static void ConfigureBlockchain(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
