using Localization.Resources.AbpUi;
using Blockchain.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Blockchain;

[DependsOn(
    typeof(BlockchainApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class BlockchainHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(BlockchainHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<BlockchainResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
