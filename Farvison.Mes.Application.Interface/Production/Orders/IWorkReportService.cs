using NPOI.OpenXmlFormats.Dml;
using System;
using System.Collections.Generic;
using WebMES.DTO.Production;
using WebMES.Model.Production;
using WebMES.Model.WareHouse;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Production.Orders
{
    public  interface IWorkReportService
    {
        

        /// <summary>
        /// 建报工单信息
        /// </summary>
        /// <param name="tzInfo"></param>
        /// <returns></returns>
        BooleanValue<BDO> CreateWorkReport(dynamic tzInfo);


        /// <summary>
        /// 删除报工信息，（IsDelete  设为1 标识为删除，并且新增一条为负数的记录标识也为1）
        /// </summary>
        /// <param name="workInfo"></param>
        /// <returns></returns>
        BooleanResult deleteWorkReport(dynamic workInfo);


        /// <summary>
        /// 根据临时表条码报工
        /// </summary>
        /// <param name="EntryID"></param>
        /// <param name="woNo"></param>
        /// <param name="Capacity"></param>
        /// <param name="isAll">是否报所有条码</param>
        /// <returns></returns>
        BooleanValue<List<BDOs>> CreateWorkReport(List<BarCodeModel> codeLst, out EnterFormModel model);




        BooleanResult RepealReport(List<string> idList);

        BooleanResult RepealBatReport(List<string> idList);
        /// <summary>
        /// 报工-无条码
        /// </summary>
        /// <param name="wrkReportInfo"></param>
        /// <returns></returns>
        BooleanValue<List<BDOs>> CreateWorkReport(List<WorkReportDto> wrkReportInfo);

        /// <summary>
        /// 报工同时用于创建流转箱
        /// </summary>
        /// <param name="wrkReportInfo"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreatePackage(WorkReportDto wrkReportInfo, int boxQty=0, string defectType = "Qualified");


        BooleanResult IntegrityCheck(WorkReportDto wrkReportInfo);

    
    }
}
