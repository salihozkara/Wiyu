using Wiyu.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Wiyu.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WiyuEntityFrameworkCoreModule),
    typeof(WiyuApplicationContractsModule)
    )]
public class WiyuDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
