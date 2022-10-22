using System.Threading.Tasks;

namespace Wiyu.Data;

public interface IWiyuDbSchemaMigrator
{
    Task MigrateAsync();
}
