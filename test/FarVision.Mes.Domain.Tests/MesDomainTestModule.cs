using FarVision.Mes.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FarVision.Mes
{
    [DependsOn(
        typeof(MesEntityFrameworkCoreTestModule)
        )]
    public class MesDomainTestModule : AbpModule
    {

    }
}