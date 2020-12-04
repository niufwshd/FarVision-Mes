using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebMES.DTO.SysData;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.System
{
    public interface ICustomImportService
    {
      
        BooleanValue<ImportViewResultDto> ImportWithPreView(DataTable dtImportData);

        BooleanValue<BDOs> GetImportBusiData(DataTable dtImportData);
    }
}
