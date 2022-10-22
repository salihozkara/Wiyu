using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wiyu.Data;
using Volo.Abp.DependencyInjection;

namespace Wiyu.EntityFrameworkCore;

public class EntityFrameworkCoreWiyuDbSchemaMigrator
    : IWiyuDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWiyuDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the WiyuDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WiyuDbContext>()
            .Database
            .MigrateAsync();
    }
}
