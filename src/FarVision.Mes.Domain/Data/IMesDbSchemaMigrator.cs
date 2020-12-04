using System.Threading.Tasks;

namespace FarVision.Mes.Data
{
    public interface IMesDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
