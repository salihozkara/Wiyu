using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Blockchain.MongoDB;

[ConnectionStringName(BlockchainDbProperties.ConnectionStringName)]
public interface IBlockchainMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
