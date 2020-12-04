using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FarVision.Mes.Data
{
    /* This is used if database provider does't define
     * IMesDbSchemaMigrator implementation.
     */
    public class NullMesDbSchemaMigrator : IMesDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}