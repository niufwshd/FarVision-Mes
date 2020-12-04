using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace FarVision.Mes.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MesEntityFrameworkCoreDbMigrationsModule),
        typeof(MesApplicationContractsModule)
        )]
    public class MesDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
