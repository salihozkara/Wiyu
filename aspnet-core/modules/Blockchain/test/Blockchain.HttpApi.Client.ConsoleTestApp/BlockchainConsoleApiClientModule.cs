using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Blockchain;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BlockchainHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class BlockchainConsoleApiClientModule : AbpModule
{

}
