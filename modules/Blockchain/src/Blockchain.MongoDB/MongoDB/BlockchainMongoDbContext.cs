using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Blockchain.MongoDB;

[ConnectionStringName(BlockchainDbProperties.ConnectionStringName)]
public class BlockchainMongoDbContext : AbpMongoDbContext, IBlockchainMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureBlockchain();
    }
}
