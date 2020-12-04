using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace FarVision.Mes.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MesHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MesConsoleApiClientModule : AbpModule
    {
        
    }
}
