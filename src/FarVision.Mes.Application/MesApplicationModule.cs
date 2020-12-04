using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.Dapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace FarVision.Mes
{
    [DependsOn(
        typeof(MesDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(MesApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
         typeof(AbpDapperModule)
        )]
    public class MesApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<MesApplicationModule>();
            });
            //context.Services.AddSingleton(new Sys_PropertysService(context.Services.GetServiceLazy<IRepository<SysProperty>>().Value));
        }
    }
}
