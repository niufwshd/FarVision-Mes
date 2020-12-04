using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;
using WebMES.Model.WareHouse;
using System.Linq.Expressions;
using WebMES.Model.Data;
using System.Net.Http;

namespace WebMES.Service.Interface.WareHouse
{
   public interface IInventoryService
    {
        /// <summary>
        /// 生成盘点计划
        /// </summary>
        /// <returns></returns>
        BooleanValue<BDOs> CreateInventoryPlan(InventoryModel model);

        /// <summary>
        /// 生成盘点计划  已有条码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateInventoryPlanInBarcode(InventoryModel model);


        /// <summary>
        /// 根据单号 获取盘点计划
        /// </summary>
        /// <param name="PlanNo"></param>
        /// <returns></returns>
        InventoryModel GetInventoryPlan(string PlanNo);


        /// <summary>
        /// 盘点条码 ID没有的话为新增条码， ID存在为扫描, 修改行项目实际数量 并且计算盘盈数量，盘亏数量
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        ResponseStatusModel<string> UpdateInventoryBarcode(InventoryBarcodeModel barcode);

        /// <summary>
        /// 修改盘点计划状态
        /// </summary>
        /// <param name="No"></param>
        /// <param name="Status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateInventoryPlanStatus(string No, string Status);

    }
}
