using System;
using System.Collections.Generic;
using System.Text;
using WebMES.DTO.ExternalInterface.Production.JL;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.ExtInterface.Production.JL
{
    /// <summary>
    /// 数据上传到MES  数采系统->MES 
    /// </summary>
    public interface IMesDataUpload
    {
        /// <summary>
        /// 上传过点
        /// </summary>
        /// <param name="lstModel"></param>
        /// <returns></returns>
        BooleanResult SubmitWorkReport(List<WorkReportInfoDto> lstModel);
    }
}
