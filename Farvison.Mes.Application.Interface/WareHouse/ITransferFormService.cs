using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;
using WebMES.Model.WareHouse;
using YueMES.Data.Services;
using WebMES.Model.Data;
using WebMES.Model.LogisticsManagement;

namespace WebMES.Service.Interface.WareHouse
{
   public interface ITransferFormService
    {
        /// <summary>
        /// 创建仓库移库(销售)
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateTranForm(TransferFormModel model);

        /// <summary>
        ///  创建下架指导
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateShelfGuide(ShelfGuideFilter filter);

        /// <summary>
        /// 创建上架指导
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateOnShelfGuide(ShelfGuideFilter filter);

        /// <summary>
        /// 修改备料计划（领料）状态
        /// </summary>
        /// <param name="no"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateMaterialPreparaPlanStatus(string no, string status);


        /// <summary>
        /// 移库单状态
        /// </summary>
        /// <param name="no"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateTranFormStatus(string no, string status);

        /// <summary>
        /// 移库单状态
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateTranFormStatus(TransferFormModel filter);


        /// <summary>
        /// 根据来源单号删除移库单
        /// </summary>
        /// <param name="Source_NO"></param>
        /// <returns></returns>
        BooleanValue<BDOs> DeleteTranForm(string Source_NO);


     

        /// <summary>
        /// 移库单确认
        /// </summary>
        /// <param name="bdos"></param>
        /// <returns></returns>
        List<BDOs> TranFormCommit(BDOs bdos);


        /// <summary>
        /// 撤销移库单(领料)确认
        /// </summary>
        /// <param name="NO">移库单号</param>
        /// <returns></returns>
        List<BDOs> CancelTranForm(string NO);


        /// <summary>
        /// 修改备料计划（领料）Item完成数量
        /// </summary>
        /// <param name="NO">备料计划单号</param>
        /// <param name="items">行项目</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateMaterialPreparaPlanItemQuantity(string NO, List<FormItem> items);


        BooleanValue<BDOs> UpdateMaterialPreparaPlanItemQuantity(string NO, FormItem item);

        /// <summary>
        /// 修改 备料计划 行项目 完成数量 未完成数量（在移库单完成之后）
        /// </summary>
        /// <param name="SourceLineNumber"> 备料计划行项目ID （GUID）唯一</param>
        /// <param name="Quantity"> 数量</param>
        /// <param name="type">类型 ，+ -</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateMaterialPreparaPlanItemQuantity(string No,string SourceLineNumber, decimal Quantity, string type);

        /// <summary>
        /// 修改备料计划Item完成数量为0
        /// </summary>
        /// <param name="NO"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateMaterialPreparaPlanItemQuantity(string NO);


        /// <summary>
        ///  修改移库单行项目批次 同一个产品有多个批次的话拆分行项目
        /// </summary>
        /// <param name="TranFormNO">移库单号</param>
        /// <param name="ItemList">行项目集合</param>
        /// <returns></returns>
        BooleanValue<BDOs> ChangeTranFormItem(string TranFormNO, List<FormItem> ItemList);



        /// <summary>
        /// 完成移库单
        /// </summary>
        /// <param name="model">移库单实体</param>
        /// <returns></returns>
        List<BDOs> CompleteTranForm(TransferFormModel model, bool IsPermission = false);

        /// <summary>
        /// 完成移库单(不检测下架指导)
        /// </summary>
        /// <param name="model">移库单实体</param>
        /// <returns></returns>
        List<BDOs> CompleteTranFormByNoShelf(TransferFormModel model);

        /// <summary>
        /// 完成移库单
        /// </summary>
        /// <param name="TranFormNO">移库单号</param>
        /// <returns></returns>
        //List<BDOs> CompleteTranForm(string TranFormNO);



        /// <summary>
        /// 移库单冲销
        /// </summary>
        /// <param name="model">移库单实体</param>
        /// <returns></returns>
        ResponseStatusModel<string> WriteOffTranForm(TransferFormModel model);



        /// <summary>
        /// 下架指导冲销
        /// </summary>
        /// <param name="model">下架指导实体</param>
        /// <returns></returns>
        List<BDOs> WriteOffShelfGuide(ShelfGuideFilter model);



        /// <summary>
        /// 上架指导冲销
        /// </summary>
        /// <param name="model">上架指导实体</param>
        /// <returns></returns>
        List<BDOs> WriteOffOnShelfGuide(ShelfGuideFilter model);



        /// <summary>
        /// 根据场景获取单据类型NO
        /// </summary>
        /// <param name="Scene">场景编号</param>
        /// <returns></returns>
        string GetFormTypeNO(string Scene);

        /// <summary>
        /// 根据单据类型获取是否需要交接参数
        /// </summary>
        /// <param name="TypeNO">类型编码</param>
        /// <returns></returns>
        bool GetIsHandover(string TypeNO);

        /// <summary>
        ///  移库单行项目完成，不带包装  只修改库存数量，不影响条码库存
        /// </summary>
        /// <param name="TranFormNo">移库单号</param>
        /// <param name="TargetWareHouseNo">移库单目标仓库</param>
        /// <param name="dr">移库单行项目dr</param>
        /// <returns></returns>
        //List<BDOs> CompleteTranFormItem(string TranFormNo, string TargetWareHouseNo, DataRow dr);




        /// <summary>
        ///  移库单行项目完成，带包装， 影响库存，影响条码库存 （来源仓库有下架指导，必带包装）
        /// </summary>
        /// <param name="TranFormNo">移库单号</param>
        /// <param name="TargetWareHouseNo">目标仓库</param>
        /// <param name="dr">行项目</param>
        /// <param name="barcodedrs">行项目条码</param>
        /// <returns></returns>
        //List<BDOs> CompleteTranFormItem(string TranFormNo, string TargetWareHouseNo, DataRow dr,DataRow[] barcodedrs);

        List<BDOs> CompleteTranFormItem(string TranFormNo, string TargetWareHouseNo, List<TransferFormProductModel> products, bool IsCompleteConfirmInspection = false );

        /// <summary>
        /// 根据单据号码 获取下架指导
        /// </summary>
        /// <param name="FormNO"></param>
        /// <returns></returns>
        ShelfGuideFilter GetShelfGuide(string FormNO);


        /// <summary>
        /// 根据单据号码 获取上架指导
        /// </summary>
        /// <param name="FormNO"></param>
        /// <returns></returns>
        ShelfGuideFilter GetOnShelfGuide(string FormNO);


        /// <summary>
        ///  判断下架指导行项目是否有条件锁定包装，包装属于 大于当前Item 剩余锁定数量的话 提示是否拆箱
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="PackageNo"></param>
        /// <param name="PackageQuantity"></param>
        /// <returns></returns>
        ResponseStatusModel<ResponseModel> IsLockPackage(string ItemID, string PackageNo, decimal PackageQuantity);



        /// <summary>
        ///  判断单据行项目是否有条件锁定包装，包装属于 大于当前Item 剩余锁定数量的话 提示是否拆箱
        /// </summary>
        /// <param name="ItemID"></param>
        /// <param name="PackageNo"></param>
        /// <param name="PackageQuantity"></param>
        /// <returns></returns>
        ResponseStatusModel<ResponseModel> IsLockPackageInForm(string ItemID, string PackageNo, decimal PackageQuantity, string FormType = "Form");

        /// <summary>
        /// 回写下架指导条码
        /// </summary>
        /// <param name="ShelfGuideNo">下架指导单号</param>
        /// <param name="productBarcodeList">条码集合</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateShelfGuideBarcode(string ShelfGuideNo, List<ProductBarcodeModel> productBarcodeList);

        /// <summary>
        /// 回写单据条码
        /// </summary>
        /// <param name="FormNo">移库单号</param>
        /// <param name="productBarcodeList">条码集合</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateFormBarcode(string FormNo, List<ProductBarcodeModel> productBarcodeList);



        /// <summary>
        /// 更改上架指导 条码来源库位，目标库位，Item状态，上架指导状态
        /// </summary>
        /// <param name="ShelfGuideNo">下架指导单号</param>
        /// <param name="productBarcodeList">条码集合</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateOnShelfGuideBarcode(string ShelfGuideNo, List<ProductBarcodeModel> productBarcodeList);


        /// <summary>
        /// 创建备料计划
        /// </summary>
        /// <param name="model">备料计划实体</param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateMaterialPreparaPlan(MaterialPreparaPlanModel model);




        /// <summary>
        /// 获取移库单
        /// </summary>
        /// <param name="FormNo">单据编号</param>
        /// <returns>移库单</returns>
        TransferFormModel GetTransferForm(string FormNo);

        /// <summary>
        /// 筛选 移库单内 已扫描条码
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        TransferFormModel TranFormScanBarcode(TransferFormModel Form);



        /// <summary>
        /// 当（跳过移库单确认）直接创建状态为准备的移库单时，需要锁定库存（准备状态 表示库存已锁定），如果来源仓库 有上下架指导，要生成下架指导
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<BDOs> TransferFormFrozenStorage(TransferFormModel model);

        /// <summary>
        ///  移库单强制下架确认（扫箱成单用）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<BDOs> TranFormForceCommit(TransferFormModel model);

        /// <summary>
        ///  完成下架指导
        /// </summary>
        /// <param name="ShelfGuideModel"></param>
        /// <returns></returns>
        List<BDOs> CompleteShelfGuide(ShelfGuideFilter ShelfGuideModel);

        /// <summary>
        /// 获取投料记录
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetFeedingHistory(FeedingFilter filter);

        /// <summary>
        /// 因工单变更 修改备料计划
        /// </summary>
        /// <param name="备料计划集合">list</param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateMaterialPreparaPlanInWorkOrderChange(List<MaterialPreparaPlanModel> list);


        /// <summary>
        /// 获取备料计划
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        MaterialPreparaPlanModel GetMaterialPreparaPlan(string No);





        /// <summary>
        /// 备料计划确认
        /// </summary>
        /// <param name="model">备料计划实体</param>
        /// <returns></returns>
        ResponseStatusModel<string> ComfirmMaterialreparaPlan(MaterialPreparaPlanModel model);


        /// <summary>
        /// 获取出库备料计划
        /// </summary>
        /// <param name="No"></param>
        /// <returns></returns>
        OutFormMaterialPreparaPlanModel GetOMaterialPreparaPlan(string No);





        /// <summary>
        /// 出库备料计划确认
        /// </summary>
        /// <param name="model">备料计划实体</param>
        /// <returns></returns>
        ResponseStatusModel<string> ComfirmOMaterialreparaPlan(OutFormMaterialPreparaPlanModel model);


        /// <summary>
        /// 根据收料获取移库单
        /// </summary>
        /// <param name="RMmodel"></param>
        /// <returns></returns>
        TransferFormModel getTransferFormInReceivingMaterial(ReceivingMaterialModel RMmodel);
        /// <summary>
        /// 生成移库单 来源质量检验
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> CreateTranFromInInspection(TransferFormModel model);

        /// <summary>
        ///  获取拣料单
        /// </summary>
        /// <param name="PickMaterialNo"></param>
        /// <returns></returns>
        List<MaterialPreparaPlanItemModel> GetPickMaterial(string PickMaterialNo);

        /// <summary>
        /// 获取出库拣料单
        /// </summary>
        /// <param name="PickMaterialNo"></param>
        /// <returns></returns>
        List<OutFormMaterialPreparaPlanItem> GetOutFormPickMaterial(string PickMaterialNo);

        /// <summary>
        /// 捡料单绑定条码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> PickMaterialBindPackageNo(ProductBarcodeModel model);

        /// <summary>
        /// 出库拣料单绑定条码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> OutFormPickMaterialBindPackageNo(ProductBarcodeModel model);


        /// <summary>
        /// 捡料单解除绑定条码
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> RemovePickMaterialBind(ProductBarcodeModel model);


        /// <summary>
        /// 根据拣料单生成移库单，并完成
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> CreateTranformInPickMaterial(ReceivingMaterialModel model);

        /// <summary>
        ///pad收料-拒收
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ResponseStatusModel<string> RefuseMaterial(ReceivingMaterialBarcode model);


        /// <summary>
        ///  拣料单确认 状态从完成待确认修改为完成
        /// </summary>
        /// <param name="PickMaterialNo">拣料单号</param>
        /// <param name="Location">存放位置</param>
        /// <returns></returns>
        BooleanValue<BDOs> PickMaterialConfirm(string PickMaterialNo,string Location);

        /// <summary>
        /// 出库拣料单确认 部分完成的拣料单修改为指定完成，并修改 计划数量 确认数量为拣料数量 释放占用库存数量（原计划数量-拣料数量）
        /// 增加未确认的出库备料计划行，并调用出库送检
        /// </summary>
        /// <param name="PickMaterialNo"></param>
        /// <param name="Location"></param>
        /// <param name="IncreaseOMPP">是否增加未确认的出库备料计划行</param>
        /// <returns></returns>
        BooleanValue<BDOs> OutFormPickMaterialConfirm(string PickMaterialNo, string Location, bool IncreaseOMPP = true);


        /// <summary>
        ///  单据确认 状态从拣配完成待确认修改为拣配完成
        /// </summary>
        /// <param name="FormNo">出移单据编号</param>
        /// <param name="Location">存放位置</param>
        /// <returns></returns>
        BooleanValue<BDOs> FormConfirm(string FormNo, string Location);

        /// <summary>
        ///  回写ERP单别单号 到单据上
        /// </summary>
        /// <param name="FormNo"></param>
        /// <param name="ERPSingle"></param>
        void WriteBackFormErpSingle(string FormNo, string ERPSingle,string ERPObject);

        /// <summary>
        ///  根据移库单 生成NCR  并占用条码库存 跟库存    20200925
        /// </summary>
        /// <param name="Model"></param>
        void GeneratorNCRInTransferForm(TransferFormModel Model);


        /// <summary>
        ///  根据（已完成、指定完成）出库拣料单 生成出库送检单
        /// </summary>
        /// <returns></returns>
        BooleanResult CreateSendInspectionOrderInOPM(List<OutFormMaterialPreparaPlanItem> ItemList);


        
        /// <summary>
        /// 获取当天发货 并且生成单据数量<最大发货量的出库申请单行数据
        /// </summary>
        /// <param name="SourceNo_Form">来源仓库</param>
        /// <param name="TargetNo_Form">目的地</param>
        /// <returns></returns>
        BooleanValue<DataTable> GetOutFormApplyItem(string SourceNo_Form, string TargetNo_Form);


        /// <summary>
        /// 根据物流任务生成移库单，并完成
        /// </summary>
        /// <param name="ItemModel">任务单行项目实体</param>
        /// <param name="No">物流任务单号</param>
        /// <returns></returns>
        ResponseStatusModel<string> CreateTranformInLogisticsTask(LogisticsTasksItemModel ItemModel, string No,string SourceWareHouse,string TargetWareHouse);


        /// <summary>
        /// 根据物流任务 送达 获取移库单
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        TransferFormModel getTransferFormInLogisticsTask(LogisticsTasksItemModel model);





    }
}
