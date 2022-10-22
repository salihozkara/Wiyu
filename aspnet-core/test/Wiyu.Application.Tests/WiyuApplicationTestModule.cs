using Volo.Abp.Modularity;

namespace Wiyu;

[DependsOn(
    typeof(WiyuApplicationModule),
    typeof(WiyuDomainTestModule)
    )]
public class WiyuApplicationTestModule : AbpModule
{

}
