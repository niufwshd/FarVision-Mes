using FarVision.Mes.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FarVision.Mes.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class MesPageModel : AbpPageModel
    {
        protected MesPageModel()
        {
            LocalizationResourceType = typeof(MesResource);
        }
    }
}