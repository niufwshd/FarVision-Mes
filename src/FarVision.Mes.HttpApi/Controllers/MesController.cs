using FarVision.Mes.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FarVision.Mes.Controllers
{
    /* Inherit your controllers from this class.
     */

    public abstract class MesController : AbpController
    {
        //private IOuterDBService _outerDBService;
        //protected MesController(IOuterDBService outerDBService)
        //{
        //    LocalizationResource = typeof(MesResource);
        //    _outerDBService = outerDBService;
        //}

        //[HttpGet]
        //[Route("GetOuterDB")]
        //public async Task<OuterDbInfo> GetOuterDbConnectionByNo()
        //{
        //    return await _outerDBService.GetOuterDbConnectionByNoAsync("1");
        //}

        protected MesController()
        {
            LocalizationResource = typeof(MesResource);
        }
    }
}