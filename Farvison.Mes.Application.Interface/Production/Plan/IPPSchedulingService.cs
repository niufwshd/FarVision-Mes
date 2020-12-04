using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebMES.DTO.SysData;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.Production.Plan
{
    /// <summary>
    /// 生产计划模块导入服务
    /// </summary>
    public interface IPPSchedulingService
    {
        /// <summary>
        /// 工单导入
        /// </summary>
        /// <param name="dtImportData"></param>
        /// <returns></returns>
        BooleanValue<List<string>> SchedulingImport(DataTable dtImportData);


        BooleanValue<ImportViewResultDto> SchedulingImportWithPreView(DataTable dtImportData);
    }
}
