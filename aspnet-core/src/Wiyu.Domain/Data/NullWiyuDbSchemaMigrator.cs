using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Wiyu.Data;

/* This is used if database provider does't define
 * IWiyuDbSchemaMigrator implementation.
 */
public class NullWiyuDbSchemaMigrator : IWiyuDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
