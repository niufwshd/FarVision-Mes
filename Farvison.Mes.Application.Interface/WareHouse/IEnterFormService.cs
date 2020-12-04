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
   public interface IEnterFormService
    {
        /// <summary>
        /// 新增入库单
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateEnterForm(EnterFormModel efmodel);


        /// <summary>
        /// 修改Asn条码状态，如果Asn条码已经扫描完成  更改Asn状态
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> EditAsnBarcodeStatus(AsnModel asn);

        /// <summary>
        /// 导入入库单（待实现）
        /// </summary>
        /// <param name="enterForms">入库单集合</param>
        BooleanValue<BDOs> ImportEnterForm(List<EnterFormModel> enterForms);

        /// <summary>
        /// 修改入库单（待实现）
        /// </summary>
        /// <param name="enterForm">入库单</param>
        BooleanValue<BDOs> UpdateEnterForm(EnterFormModel enterForm);

        /// <summary>
        /// 撤销入库单（待实现）
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> CancelEnterForm(int id);

        /// <summary>
        /// 冲销入库单（待实现）
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> WriteOffEnterForm(int id);

        /// <summary>
        /// 生效入库单（待实现）
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> ActiveEnterForm(int id);

        /// <summary>
        /// 生效多个入库单（待实现）
        /// </summary>
        /// <param name="ids">唯一编号集合</param>
        BooleanValue<BDOs> ActiveEnterForm(List<int> ids);

        /// <summary>
        /// 完成入库单（待实现）
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> FinishEnterForm(int id);

        /// <summary>
        /// 完成多个入库单（待实现）
        /// </summary>
        /// <param name="ids">唯一编号集合</param>
        BooleanValue<BDOs> FinishEnterForm(List<int> ids);

        /// <summary>
        /// 完成入库单（待实现）
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> FinishEnterForm(EnterFormModel EnterForm, EnterFormProductModel EnterFormItem, PackageModel Package);

        /// <summary>
        /// 完成入库
        /// </summary>
        /// <param name="EnterForm">入库单实体</param>
        /// <returns></returns>
        List<BDOs> FinishEnterForm(EnterFormModel EnterForm, bool IsPermission = false, bool IsRecordBarcode = true);


    
        /// <summary>
        /// 修改入库单状态
        /// </summary>
        /// <param name="No">入库单号</param>
        /// <param name="status">状态</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateEnterFormStatus(string No, string status);

        /// <summary>
        /// 修改入库单状态
        /// </summary>
        /// <param name="model">入库单实体</param>
        /// <returns></returns>

        BooleanValue<BDOs> UpdateEnterFormStatus(EnterFormModel model);
        /// <summary>
        /// 获取入库单
        /// </summary>
        /// <param name="No">入库单号</param>
        /// <returns>入库单</returns>
        EnterFormModel GetEnterForm(string No);


        /// <summary>
        /// 修改到货通知单状态
        /// </summary>
        /// <param name="AsnNo"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateAsnStatus(string AsnNo, string status);

        /// <summary>
        /// 创建asn单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateAsn(AsnModel model);




        /// <summary>
        /// 根据条件获取入库单（待实现）
        /// </summary>
        /// <param name="predicate">查询条件</param>
        /// <returns>入库单</returns>
        EnterFormModel GetEnterForm(Expression<Func<EnterFormModel, bool>> predicate);

        ///// <summary>
        ///// 根据条件查询入库单
        ///// </summary>
        ///// <param name="predicate">查询条件</param>
        ///// <param name="pages">分页信息</param>
        ///// <returns>入库单集合</returns>
        //List<EnterFormModel> QueryEnterForm(Expression<Func<EnterFormModel, bool>> predicate, Pages pages = null);

        /// <summary>
        /// 新增入库单（待实现）
        /// </summary>
        /// <param name="enterForm">入库单</param>
        BooleanValue<BDOs> AddEnterFormInternal(EnterFormModel enterForm);

        /// <summary>
        /// 生效入库单（待实现）
        /// </summary>
        /// <param name="enterForm">入库单</param>
        BooleanValue<BDOs> ActiveEnterFormInternal(EnterFormModel enterForm);

        /// <summary>
        /// 完成入库单（待实现）
        /// </summary>
        /// <param name="enterForm">入库单</param>
        /// <param name="isNew">是否新建</param>
        BooleanValue<BDOs> FinishEnterFormInternal(EnterFormModel enterForm, bool isNew);




        /// <summary>
        /// 根据Asn单号 获取Asn单 
        /// </summary>
        /// <param name="AsnNo"></param>
        /// <returns></returns>
        AsnModel GetAsn(string AsnNo);




        /// <summary>
        /// 筛选出入库单已经扫描的条码
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        EnterFormModel EnterFormScanBarcode(EnterFormModel Form);


        /// <summary>
        /// 入库单冲销
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> WriteOffEnterForm(EnterFormModel model);



        /// <summary>
        /// asnItem生成条码
        /// </summary>
        /// <param name="ItemID">行项目ID</param>
        /// <param name="Quantity">生成数量</param>
        /// <param name="BoxQty">每箱数量</param>
        /// <returns></returns>
        ResponseStatusModel<string> AsnItemInsertBarcode(string ItemID,decimal Quantity,decimal BoxQty);


        /// <summary>
        /// 根据产品 生成条码，期初入库
        /// </summary>
        /// <param name="Location">库位</param>
        /// <param name="Prod_No">产品</param>
        /// <param name="Batch_No">批次</param>
        /// <param name="AllQuantity">总数量</param>
        /// <param name="PkgQuantity">每箱数量</param>
        /// <param name="MaterialBatch_No">原料批次</param>
        /// <returns></returns>
        ResponseStatusModel<string> CreateInitialInventory(string Location, string Prod_No, string Batch_No, decimal AllQuantity, decimal PkgQuantity, string ProductionDate, string Cust_NO,string MaterialBatch_No);
        //ResponseStatusModel<string> RejectedMaterial(RejectedMaterialModel rejectedMaterialModel);




        ResponseStatusModel<string> CreateAsnForm(AsnModel asn);

        /// <summary>
        ///  在asn单完成之后, 调用生成送检单接口 
        /// </summary>
        /// <param name="AsnNo"></param>
        /// <returns></returns>
        List<BooleanResult> CreateSendInspectionOrder(string AsnNo);

        /// <summary>
        /// 根据入库单生成送检单
        /// </summary>
        /// <param name="EFModel"></param>
        void CreateSendInspectionOrder(EnterFormModel EFModel);


        /// <summary>
        /// 报工入库接口
        /// </summary>
        /// <param name="model">入库单</param>
        /// <returns></returns>
        ResponseStatusModel<string> CreateEnterFormInWorkOrder(EnterFormModel model);


        /// <summary>
        /// 根据工单BOM扣除原料（工作中心下产线原料仓库 ），在报工生成指定的成品 装箱入库(工作中心下产线目的仓库)后在移库
        /// </summary>
        /// <param name="WO_NO">工单</param>
        /// <param name="Quantity">报工数量</param>
        /// <param name="PackageNo">装箱的箱条码</param>
        /// <param name="Batch_No">批次</param>
        /// <param name="ProductionDate">生产日期</param>
        void WorkOrderPutInStorage(string WO_NO, decimal Quantity, string PackageNo, string Batch_No, string ProductionDate);

        

    }
}
