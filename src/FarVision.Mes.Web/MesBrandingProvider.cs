using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FarVision.Mes.Web
{
    [Dependency(ReplaceServices = true)]
    public class MesBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Mes";
    }
}
