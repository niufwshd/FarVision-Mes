using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebMES.DTO.SysData;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Quality
{
    public interface IInspSchemeService
    {
        BooleanValue<ImportViewResultDto> InspSchemeImportWithPreView(DataTable dtImportData);

        BooleanValue<BDOs> GetImportBusiData(DataTable dtImportData);

    }
}
