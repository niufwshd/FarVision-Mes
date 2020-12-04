using System;
using System.Collections.Generic;
using System.Text;
using FarVision.Mes.Localization;
using Volo.Abp.Application.Services;

namespace FarVision.Mes
{
    /* Inherit your application services from this class.
     */
    public abstract class MesAppService : ApplicationService
    {
        protected MesAppService()
        {
            LocalizationResource = typeof(MesResource);
        }
    }
}
