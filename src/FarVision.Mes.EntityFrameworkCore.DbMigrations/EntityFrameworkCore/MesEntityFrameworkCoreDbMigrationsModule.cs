using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace FarVision.Mes.EntityFrameworkCore
{
    [DependsOn(
        typeof(MesEntityFrameworkCoreModule)
        )]
    public class MesEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MesMigrationsDbContext>();
        }
    }
}
