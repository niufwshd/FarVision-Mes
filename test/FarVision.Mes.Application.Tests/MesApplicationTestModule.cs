using Volo.Abp.Modularity;

namespace FarVision.Mes
{
    [DependsOn(
        typeof(MesApplicationModule),
        typeof(MesDomainTestModule)
        )]
    public class MesApplicationTestModule : AbpModule
    {

    }
}