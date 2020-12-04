using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebMES.Model.Data;
using WebMES.Model.ERPModels.Model;
using WebMES.Model.Quality;
using WebMES.Model.WareHouse;

namespace WebMES.Service.Interface.ExtInterface.XL
{
    public interface IMES2ERPService
    {
        /// <summary>
        /// 调拨单erp
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendAllocateBill2ERP(TransferFormModel model);

        /// <summary>
        /// 借出单
        /// </summary>
        /// <param name="transferFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendInOutResponseModel2ERP(TransferFormModel transferFormModel);

        /// <summary>
        /// 出入库归还单ERP接口 
        /// </summary>
        /// <param name="transferFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendInOutReturnResponseModel2ERP(TransferFormModel transferFormModel);

        /// <summary>
        /// 报废ERP接口
        /// </summary>
        /// <param name="transferFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendDiscardResponseModel2ERP(TransferFormModel transferFormModel);

        /// <summary>
        /// 进货类型 erp报废接口
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendDiscardResponseModel2ERP(List<DiscardResponseHead> items);

        /// <summary>
        /// 退货
        /// </summary>
        /// <param name="outFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendRejectGoodsResponseModel2ERP(OutFormModel outFormModel);

        /// <summary>
        /// 进货  验收时触发
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendStockGoodsResponseModel2ERP(List<StockGoodsResponseHead> model);
        /// <summary>
        /// 进货 入库单完成时触发
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendStockGoodsResponseModel2ERP(EnterFormModel model);

        /// <summary>
        /// 冲销
        /// </summary>
        /// <param name="ErpNo"></param>
        /// <param name="ErpType"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendChargeAgainstResponse2ERP(string ErpNo, string ErpType);

        /// <summary>
        /// 领料  投料时触发
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendPickingResponse2ERP(List<PickingResponseHead> list);

        /// <summary>
        /// 生产入库单ERP接口
        /// </summary>
        /// <param name="enterFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendProductionInWarehouseResponseModel2ERP(EnterFormModel enterFormModel);

        /// <summary>
        ///  库存调整erp接口 盘点调增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendWareHouseAdjustResponse2ERP(EnterFormModel model);

        /// <summary>
        ///  库存交易单 -物料退货单 （移库）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendWareHouseAdjustResponse2ERP(TransferFormModel model);

        /// <summary>
        /// 库存交易(盘点调减)
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendWareHouseAdjustResponse2ERP(OutFormModel model);

        /// <summary>
        /// 委外进货erp接口
        /// </summary>
        /// <param name="enterFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendOutsideStockGoodsResponse2ERP(List<OutsideStockGoodsResponseHead> items);


        /// <summary>
        /// 委外进货erp接口
        /// </summary>
        /// <param name="enterFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendOutsideStockGoodsResponse2ERP(TransferFormModel model);

        /// <summary>
        /// 委外退货
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendOutsideReturnGoodsResponse2ERP(TransferFormModel model);


        /// <summary>
        /// 销售发货单
        /// </summary>
        /// <param name="enterFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendSaleSendGoodsResponse2ERP(OutFormModel enterFormModel);
        /// <summary>
        /// 销售退货
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendSaleReturnGoodsResponse2ERP(EnterFormModel model);

        /// <summary>
        /// 销毁单erp接口  //报废单
        /// </summary>
        /// <param name="enterFormModel"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendDestroyGoodsResponse2ERP(OutFormModel enterFormModel);

        //投料撤销时触发
        ResponseStatusModel<string> SendRejectMaterialResponse2ERP(List<RejectMaterialResponseHead> ItemList);
        

    }
}