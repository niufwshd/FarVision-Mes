using YueMES.Base.Utils;
using WebMES.DTO.Filter;
using WebMES.Model.Production;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.DTO.Production;

namespace WebMES.Service.Interface.Production.Orders
{
    public interface IOrderQueryService
    {

        /// <summary>
        /// 根据条件取排产工单
        /// </summary>
        /// <param name="zcNo"></param>
        /// <param name="sebNo"></param>
        /// <param name="banNo"></param>
        /// <param name="schDate"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getSchedulingOrders(string zcNo, string sebNo, string banNo, DateTime schStartDate,DateTime schEndDate);


        /// <summary>
        /// 根据条件取没有排产的产品
        /// </summary>
        /// <param name="zcNo">工序</param>
        /// <param name="sebNo">设备</param>
        /// <param name="banNo">班次</param>
        /// <param name="banStartTime">班次开始时间</param>
        /// <returns></returns>
        BooleanValue<DataTable> getUnSchedulingProduct(string zcNo, string sebNo, string banNo, DateTime banStartTime);


        /// <summary>
        /// 根据条件分页取没有排产的产品
        /// </summary>
        /// <param name="zcNo">工序</param>
        /// <param name="sebNo">设备</param>
        /// <param name="banNo">班次</param>
        /// <param name="banStartTime">班次开始时间</param>
        /// <returns></returns>
        BooleanValue<DataTable> getUnSchedulingProduct(bool isAll, int page, int pageSize, string zcNo, string sebNo, string banNo, DateTime banStartTime, List<CustomConditions> filterCols, out int rowsCount);

        /// <summary>
        /// 无工单得工序取报工数量
        /// </summary>
        /// <param name="idNo"></param>
        /// <param name="moNo"></param>
        /// <param name="zcNo"></param>
        /// <param name="sebNo"></param>
        /// <param name="banNo"></param>
        /// <param name="tzDD"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getWorkReportResult(string prdNo, string moNo, string zcNo, string sebNo, string banNo, DateTime tzDD);




        /// <summary>
        /// 根据工单取报工数量
        /// </summary>
        /// <param name="tzNo"></param>
        /// <param name="zcNo"></param>
        /// <returns></returns>
        BooleanValue<DataTable> getWorkReportResult(string tzNo,string zcNo);


       

        /// <summary>
        /// 取给定工序,工位当班的排产工单，并绑定初始登录人员
        /// </summary>
        /// <param name="processNo"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetLoginOrders(string processNo,string stationNo);


        /// <summary>
        /// 取给定工序，给定班次的排产工单，并绑定初始登录人员
        /// </summary>
        /// <param name="processNo"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetLoginOrders(string processNo, string shiftNo, DateTime shiftDate, DateTime shiftEndDate);

        /// <summary>
        /// 根据条件取汇总的排产工单信息
        /// </summary>
        /// <param name="filterCond"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetOrderProductSummary(filterConidtions filterCond);


        /// <summary>
        /// 取报工产品工单
        /// </summary>
        /// <param name="startTime">派工开始时间</param>
        /// <param name="endTime">派工结束时间</param>
        /// <param name="rptInfoList"></param>
        /// <returns></returns>
        BooleanResult GetReportProductOrder(DateTime startTime, DateTime endTime, List<WorkReportDto> rptInfoList);

    }
}
