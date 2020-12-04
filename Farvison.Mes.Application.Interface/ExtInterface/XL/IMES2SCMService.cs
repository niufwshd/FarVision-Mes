using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebMES.Model.Data;
using WebMES.Model.Quality;
using WebMES.Model.SCMModels.Model.ResponseModels;
using WebMES.Model.WareHouse;

namespace WebMES.Service.Interface
{
    public interface IMES2SCMService
    {

        /// <summary>
        ///  采购订单到货数量接口
        /// </summary>
        /// <param name="asn">asn实体</param>
        /// <returns></returns>
        ResponseStatusModel<string> PurchaseOrderArrivesToSCM(AsnModel asn);

        /// <summary>
        /// 采购到货验收数量接口
        /// </summary>
        /// <param name="asn"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendReceiveItemBillToSCM(AcceptanceFormModel model);

        ResponseStatusModel<string> ReCheckMaterial2SCM(RecheckModelResponseModel model);

        ResponseStatusModel<string> ReCheckMaterial2SCMOutSource(RecheckOutSourceModelResponseModel model);

        ResponseStatusModel<string> ReceiveGoods2SCM(ReceiveGoodsResponseModel model);

        ResponseStatusModel<string> ReturnGoods2SCM(ReturnGoodsResponseModel model);

        ResponseStatusModel<string> WorkerOrder2SCM (WorkOrderResponseModel model);

    }
}