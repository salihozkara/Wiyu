using Wiyu.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Wiyu;

[DependsOn(
    typeof(WiyuEntityFrameworkCoreTestModule)
    )]
public class WiyuDomainTestModule : AbpModule
{

}
