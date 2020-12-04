using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using WebMES.DTO.ExternalInterface.GDYT;
using WebMES.Model.WareHouse;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.ExtInterface.GDYT.U9OuterInterface
{
    public interface IU9OuterInterface
    {
        BooleanValue<DataRow> GetInterFaceConfig(string InterfaceCode);
        /// <summary>
        /// MES工单开工--->U9生产订单开工
        /// </summary>
        /// <param name="woNo"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        BooleanResult SendWorkStart(string woNo);


        /// <summary>
        /// MES生产退料--->U9生产退料单(来源MO)
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        BooleanResult SendRejectedMaterial(string woNo, string materialNo, decimal qty);

        /// <summary>
        /// MES成品入库-- U9成品入库单(来源MO)
        /// </summary>
        /// <param name="woNo">工单号</param>
        /// <param name="materialNo">品号</param>
        /// <param name="batchNo">批次</param>
        /// <param name="whseNo">仓库</param>
        /// <param name="qty">数量</param>
        /// <returns></returns>
        BooleanResult SendWorkReport(EnterFormModel model);

        /// <summary>
        /// MES成品出库-->U9出货单(无来源)
        /// </summary>
        /// <param name="shipmentInfoList"></param>
        /// <returns></returns>
        BooleanResult SendShipment(List<U9ShipmentDto> shipmentInfoList);

        /// <summary>
        /// MES工单/MES成品出库-->U9调入单(无来源)
        /// </summary>
        /// <param name="materialNo"></param>
        /// <param name="batchNo"></param>
        /// <param name="whseNo"></param>
        /// <param name="qty"></param>
        /// <returns></returns>
        BooleanResult SendTransfer(TransferFormModel model);



        //MES工单--->U9杂发单(来源MO)，MES工单--->U9生产领料单(来源MO)，//库存查询 走调度服务
    }
}
