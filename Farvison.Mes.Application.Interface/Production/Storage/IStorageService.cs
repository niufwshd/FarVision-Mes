using System.Collections.Generic;
using System.Data;
using WebMES.DTO.SysData;
using WebMES.Model.Data;
using WebMES.Model.WareHouse;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Production.Storage
{
    public interface IStorageService
    {

        /// <summary>
        /// 库存
        /// </summary>
        /// <param name="storage"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateStorage(StorageModel storage);

        /// <summary>
        /// 批量更改库存
        /// </summary>
        /// <param name="storages"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateStorage(List<StorageModel> storages);


        /// <summary>
        ///  更新投料记录（投料或者退料   记录历史）
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateProductionFeed(FeedingModel model);
        

            /// <summary>
            /// 库存
            /// </summary>
            /// <param name="info"></param>
            /// <returns></returns>
            BooleanValue<BDOs> CreateStorage(dynamic info);


        /// <summary>
        /// 入库单
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateEnterForm(dynamic info);

        /// <summary>
        /// 修改入库单状态
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateEnterForm(dynamic info);





        /// <summary>
        /// 修改移库单状态
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateTransferForm(dynamic info);

        /// <summary>
        /// 修改出库单状态
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateOutForm(dynamic info);
        /// <summary>
        /// 修改包装状态
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDO> UpdatePackage(dynamic info);


        /// <summary>
        /// 投料
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> InsertProductionFeed(dynamic info,dynamic infos);

        /// <summary>
        /// 修改包装记录
        /// </summary>
        /// <param name="info"></param>
        /// <param name="infos"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdatePackageResult(dynamic info, dynamic infos);


        /// <summary>
        /// 批量增加出入单
        /// </summary>
        /// <param name="info"></param>
        /// <param name="infos"></param>
        /// <returns></returns>
        BooleanValue<BDOs> InsertAllOutForm(dynamic info, dynamic infos);

        /// <summary>
        /// 批量修改库存
        /// </summary>
        /// <param name="info"></param>
        /// <param name="infos"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdatgeAllStorage(dynamic info, dynamic infos);


        /// <summary>
        /// U9 计划开工接口
        /// </summary>
        /// <param name="Info"></param>
        /// <returns></returns>
        BooleanResult SendPlanWorkStartToU9(dynamic Info, dynamic infos);

        /// <summary>
        /// 获取仓库组织架构
        /// </summary>
        /// <returns></returns>
        BooleanValue<DataTable> GetWareHouseORG();



        /// <summary>
        /// 冻结库存数量
        /// </summary>
        /// <param name="StorageID"></param>
        /// <param name="ForzenQuantity"></param>
        /// <returns></returns>
        BooleanValue<BDOs> ForzenStorageQuantity(string StorageID, decimal ForzenQuantity);


        /// <summary>
        /// 确认仓库库存  -- 先进先出 到批次 （2020-01-06，确认库存  从库位修改为到批次 ）
        /// </summary>
        /// <param name="prod_no"></param>
        /// <param name="warehouse"></param>
        /// <param name="Batch_No"></param>
        /// <param name="UnQuantity"></param>
        /// <returns></returns>
        List<FormItem> GetWareHouseStroage(string prod_no, string warehouse, string Batch_No, decimal UnQuantity);

        /// <summary>
        /// 备料计划确认库存 
        /// </summary>
        /// <param name="prod_no"></param>
        /// <param name="warehouse"></param>
        /// <param name="Batch_No"></param>
        /// <param name="UnQuantity"></param>
        /// <returns></returns>
        List<FormItem> GetWareHouseStroageInMaterialPreparaPlan(string prod_no, List<string> warehouse, string Batch_No, decimal UnQuantity);



        /// <summary>
        /// 出库备料计划确认库存 -- 先进先出到批次， 不包含出货待检区的物料
        /// </summary>
        /// <param name="prod_no">产品</param>
        /// <param name="WareHouse">仓库</param>
        /// <param name="Batch_No">批次</param>
        /// <param name="UnQuantity">需求数量</param>
        /// <param name="ShipmentInspectArea"> 出货待检区</param>
        /// <returns></returns>
        List<FormItem> GetWareHouseStroageInOMaterialPreparaPlan(string prod_no, string WareHouse, string Batch_No, decimal UnQuantity, string ShipmentInspectArea);


        /// <summary>
        ///  确认仓库库存 带批次
        /// </summary>
        /// <param name="prod_no">物料</param>
        /// <param name="warehouse">仓库</param>
        /// <param name="batch_no">批次</param>
        /// <param name="UnQuantity">需要数量</param>
        /// <param name="transferFormService"></param>
        /// <returns></returns>
        List<FormItem> GetWareHouseStroage(string prod_no, List<string> warehouses, string batch_no, decimal UnQuantity);





        ///确认仓库库存 无批次
        /// </summary>
        /// <param name="prod_no">物料</param>
        /// <param name="warehouse">仓库</param>
        /// <param name="UnQuantity">需要数量</param>
        /// <param name="transferFormService"></param>
        /// <returns></returns>
        List<FormItem> GetWareHouseStroage(string prod_no, List<string> warehouses, decimal UnQuantity);

        /// <summary>
        /// 确认仓库库存(根据条码强制指定)
        /// </summary>
        /// <param name="prod_no">物料</param>
        /// <param name="warehouses">仓库</param>
        /// <param name="ProductBarcodeList">条码集合</param>
        /// <returns></returns>
        List<FormItem> GetWareHouseStroage(string prod_no, string warehouses, List<ProductBarcodeModel> ProductBarcodeList);

        /// <summary>
        /// 获取冻结库存
        /// </summary>
        /// <param name="prod_no">产品</param>
        /// <param name="warehouse">仓库</param>
        /// <param name="Quantity">数量</param>
        /// <param name="Batch_NO">批次</param>
        /// <returns></returns>
        List<FormItem> GetForzenStroage(string prod_no, string warehouse, decimal Quantity, string Batch_NO);

        /// <summary>
        /// 解冻库存数量
        /// </summary>
        /// <param name="StorageID"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        BooleanValue<BDOs> StorageUnfreezing(string StorageID, decimal Quantity);


        /// <summary>
        /// 获取生产投料BOM,工单下这个产品的 已领用量
        /// </summary>
        /// <param name="WO_NO"></param>
        /// <param name="PROD_NO"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetProductionFeedUseQuantity(string WO_NO, string PROD_NO);


        /// <summary>
        /// 创建库存冻结数量
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateFrozenStorage(FormItem model);
        /// <summary>
        /// 创建库存冻结数量 
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateFrozenStorage(List<FormItem> modelList);


        /// <summary>
        /// 减少库存冻结数量（完成单据之后）
        /// </summary>
        /// <param name="No">单据号</param>
        /// <param name="WareHouseNo">仓库编号</param>
        /// <param name="prod_No">品号</param>
        /// <param name="Batch_No">批次</param>
        /// <param name="ProductionDate">生产日期</param>
        /// <param name="Quantity">数量</param>
        /// <returns></returns>
        BooleanValue<BDOs> SubtractFrozenStorage(string No, string WareHouseNo, string prod_No, string Batch_No, string ProductionDate, decimal Quantity);
        /// <summary>
        /// 减少库存冻结数量 （批量）
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        BooleanValue<BDOs> SubtractFrozenStorage(List<FormItem> modelList);


        /// <summary>
        /// 根据条码获取库存
        /// </summary>
        /// <param name="Prod_No">产品</param>
        /// <returns>条码库存</returns>
        BooleanValue<DataTable> GetInventoryInProd_No(string Prod_No);

        /// <summary>
        /// 创建条码库存锁定记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateStorageBarcodeLock(List<StorageBarcodeLockModel> modelList);

        /// <summary>
        /// 减少条码库存锁定记录
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        BooleanValue<BDOs> ReduceStorageBarcodeLock(List<StorageBarcodeLockModel> modelList);


        /// <summary>
        /// 生产投料
        /// </summary>
        /// <param name="pfList">投料实体集合</param>
        /// <returns></returns>
        ResponseStatusModel<string> InsertProductionFeed(List<ProductionFeedModel> pfList);


        /// <summary>
        /// 生产退料
        /// </summary>
        /// <param name="model">生产退料实体</param>
        /// <returns></returns>
        ResponseStatusModel<string> RejectedMaterial(RejectedMaterialModel model);


        /// <summary>
        /// 根据产品+仓库 获取条码库存  按批次，生产日期排序
        /// </summary>
        /// <param name="prod_no"></param>
        /// <param name="WareHouse"></param>
        /// <param name="Batch_No"></param>
        /// <param name="UnQuantity"></param>
        /// <returns></returns>
        List<ProductBarcodeModel> GetStorageBarcode(string prod_no, string WareHouse, string Batch_No, decimal UnQuantity);


        /// <summary>
        /// 记录Pad收料历史
        /// </summary>
        /// <param name="model">收料实体</param>
        void CreateReceivingMaterialHistory(ReceivingMaterialModel model);


        /// <summary>
        /// 期初入库导入
        /// </summary>
        /// <param name="dtImportData"></param>
        /// <returns></returns>
        BooleanValue<ImportViewResultDto> InitialInventoryImportWithPreView(DataTable dtImportData);


        /// <summary>
        /// 批量锁定库存
        /// </summary>
        /// <param name="lst"></param>
        void FreezeStorage(List<FreezeStorageModel> lst);


        /// <summary>
        /// 生成待收料数据
        /// </summary>
        /// <param name="modelList"></param>
        /// <returns></returns>
        void GenerateReceiveMaterial(List<ReceiveMaterialModel> modelList);




        /// <summary>
        /// 修改待收料记录，记录历史
        /// </summary>
        /// <param name="model"></param>
        void UpdateReceiveMaterial(ReceivingMaterialBarcode model);

    }
}
