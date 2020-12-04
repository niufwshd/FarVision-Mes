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

namespace WebMES.Service.Interface.WareHouse
{
    public interface IOutFormService
    {
        /// <summary>
        /// 出库单
        /// </summary>
        /// <param name="outformModel"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateOutForm(OutFormModel model);
        /// <summary>
        /// 修改DN单状态（出库申请单）
        /// </summary>
        /// <param name="no"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateOutFormApplyStatus(string no, string status);


        /// <summary>
        /// 导入出库单(待实现)
        /// </summary>
        /// <param name="outForms">出库单集合</param>
        BooleanValue<BDOs> ImportOutForm(List<OutFormModel> outForms);

        /// <summary>
        ///修改出库单状态
        /// </summary>
        /// <param name="outForm">出库单</param>
        BooleanValue<BDOs> UpdateOutFormStatus(string no, string status);

        /// <summary>
        /// 撤销出库单
        /// </summary>
        /// <param name="id">唯一编号</param>
        List<BDOs> CancelOutForm(string NO);

        /// <summary>
        /// 冲销出库单(待实现)
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> WriteOffOutForm(int id);

        /// <summary>
        /// 生效出库单(待实现)
        /// </summary>
        /// <param name="id">唯一编号</param>
        List<BDOs> ActiveOutForm(BDOs bdos);

        /// <summary>
        /// 生效多个出库单(待实现)
        /// </summary>
        /// <param name="ids">唯一编号集合</param>
        List<BDOs> ActiveOutForm(List<string> nos, string IsOff);

        /// <summary>
        /// 修改出库申请 Item转单数量,Item状态
        /// </summary>
        /// <param name="NO"></param>
        /// <param name="itemList"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateOutFormApplyItemQuantity(string NO, List<FormItem> itemList);

        /// <summary>
        /// 修改出库申请 item完成数量 表头状态
        /// </summary>
        /// <param name="NO"></param>
        /// <param name="itemList"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateOutFormApplyItemFinishQuantity(string NO, List<FormItem> itemList);

        /// <summary>
        /// 完成出库单
        /// </summary>
        /// <param name="id">唯一编号</param>
        //List<BDOs> FinishOutForm(string NO);

        /// <summary>
        /// 完成多个出库单(待实现)
        /// </summary>
        /// <param name="ids">唯一编号集合</param>
        BooleanValue<BDOs> FinishOutForm(List<int> ids);

        /// <summary>
        /// 获取出库单(待实现)
        /// </summary>
        /// <param name="id">唯一编号</param>
        /// <returns>出库单</returns>
        OutFormModel GetOutForm(int id);


        /// <summary>
        /// 获取出库单
        /// </summary>
        /// <param name="FormNo">单据编号</param>
        /// <returns>出库单</returns>
        OutFormModel GetOutForm(string FormNo);



        /// <summary>
        /// 根据条件获取出库单(待实现)
        /// </summary>
        /// <param name="predicate">查询条件</param>
        /// <returns>出库单</returns>
        OutFormModel GetOutForm(Expression<Func<OutFormModel, bool>> predicate);

        ///// <summary>
        ///// 根据条件查询出库单(待实现)
        ///// </summary>
        ///// <param name="predicate">查询条件</param>
        ///// <param name="pages">分页信息</param>
        ///// <returns>出库单集合</returns>
        //List<OutFormModel> QueryOutForm(Expression<Func<OutFormModel, bool>> predicate, Pages pages = null);

        /// <summary>
        /// 新增出库单(待实现)
        /// </summary>
        /// <param name="outForm">出库单</param>
        BooleanValue<BDOs> AddOutFormInternal(OutFormModel outForm);

        /// <summary>
        /// 生效出库单(待实现)
        /// </summary>
        /// <param name="outForm">出库单</param>
        BooleanValue<BDOs> ActiveOutFormInternal(OutFormModel outForm);

        /// <summary>
        /// 完成出库单(待实现)
        /// </summary>
        /// <param name="outForm">出库单</param>
        /// <param name="isNew">是否新建</param>
        BooleanValue<BDOs> FinishOutFormInternal(OutFormModel outForm, bool isNew);

        /// <summary>
        /// 完成出库单
        /// </summary>
        /// <param name="OutForm"></param>
        /// <returns></returns>
        List<BDOs> FinishOutForm(OutFormModel OutForm, bool IsPermission = false);


        /// <summary>
        /// 筛选出库单已经扫描的条码
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        OutFormModel OutFormScanBarcode(OutFormModel Form);

        /// <summary>
        /// //筛选 出库单中 领料模式 不为倒扣数据
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        OutFormModel GetOutFormInFeedType(OutFormModel Form, List<ProductionFeedModel> FeedModels);

        /// <summary>
        /// 当（跳过确认出库单）直接创建状态为准备的出库单时，需要锁定库存（准备状态 表示库存已锁定）
        /// </summary>
        /// <param name="model">出库单实体</param>
        /// <returns></returns>
        List<BDOs> OutFormFrozenStorage(OutFormModel model);

        /// <summary>
        /// 根据工单完成出库单(投料 倒扣模式)
        /// </summary>
        /// <param name="WO_NO"></param>
        /// <param name="PROD_NO"></param>
        /// <param name="Quantity"></param>
        /// <param name="VerNO">版本号</param>
        /// <returns></returns>
        ResponseStatusModel<string> FinishOutFormInWorkOrder(string WO_NO, string PROD_NO, decimal Quantity, string VerNO,string OutPutNo,out string OutFormNo);


        /// <summary>
        /// 出库单冲销
        /// </summary>
        /// <param name="model">出库单实体</param>
        /// <returns></returns>
        ResponseStatusModel<string> WriteOffOutForm(OutFormModel model);

        /// <summary>
        ///  生成出库单 来源质量检验
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> CreateOutFromInInspection(OutFormModel model);


        /// <summary>
        /// 根据BOM获取产品所需物料量  
        /// 2020-06-01 仅获取领料模式为倒扣的物料
        /// </summary>
        /// <param name="PROD_NO">产品</param>
        /// <param name="VerNO">版本号</param>
        /// <param name="Quantity">数量</param>
        /// <returns></returns>
        List<ProductDosageModel> GetProductDosage(string PROD_NO, string VerNO, decimal Quantity);



        /// <summary>
        /// 获取工单所需物料量
        /// </summary>
        /// <param name="WO_NO">工单</param>
        /// <param name="MPROD_NO">母件产品</param>
        /// <param name="Quantity">报工数量</param>
        /// <returns></returns>
        List<ProductDosageModel> GetProductDosageInWorkOrderMats(string WO_NO, string MPROD_NO,decimal Quantity);



        /// <summary>
        /// 报工撤销 倒扣物料 根据bom生成原料 生成入库单 并用工单占用库存
        /// </summary>
        /// <param name="WO_NO"></param>
        /// <param name="PROD_NO"></param>
        /// <param name="Quantity"></param>
        /// <param name="VerNO"></param>
        /// <returns></returns>
        ResponseStatusModel<string> WriteOffOutFormInWorkOrder(string WO_NO, string OutPutID);

        /// <summary>
        /// 创建出库备料计划
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateOutFormMaterialPreparaPlan(OutFormMaterialPreparaPlanModel model);

        /// <summary>
        /// 出库送检单验收完成 回写出库申请单(出库拣料单)合格数量，不合格数量
        /// </summary>
        /// <param name="PickMaterialID">拣料单ID</param>
        /// <param name="UnQualifiedQuantity">不合格数量</param>
        /// <param name="QualifiedQuantity">合格数量</param>
        /// <returns></returns>
        void UpdateOutFormApplyItemUnQuantity(string PickMaterialID, decimal UnQualifiedQuantity, decimal QualifiedQuantity);
        /// <summary>
        ///   工单撤销 撤销出库单并用工单占用
        /// </summary>
        /// <param name="OutFormNo">出库单号</param>
        /// <param name="WO_NO">工单</param>
        void CancelOutFormInWorkOrder(string OutFormNo,string WO_NO);

    }
}
