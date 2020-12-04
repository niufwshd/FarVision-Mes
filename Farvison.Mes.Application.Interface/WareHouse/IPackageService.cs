using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;
using WebMES.Model.WareHouse;
using WebMES.Model.Data;

namespace WebMES.Service.Interface.WareHouse
{
   public interface IPackageService
    {
        /// <summary>
        /// 批量创建包装
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreatePackage(List<PackageModel> model);


        BooleanValue<BDOs> CreatePackage(PackageModel item);


        /// <summary>
        /// 修改包装数量
        /// </summary>
        /// <param name="PackageNo"></param>
        /// <param name="Prod_No"></param>
        /// <param name="Batch_No"></param>
        /// <param name="Quantity"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdatePackageQuantity(string PackageNo, string Prod_No,string Batch_No,decimal Quantity, string Type);

        /// <summary>
        /// 批量修改包装数量
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdatePackageQuantity(List<UpdatePackageFilter> filter);

        /// <summary>
        /// 条码库存
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateStorageBarcode(List<StorageBarcodeModel> model);


        /// <summary>
        ///   包装锁定
        /// </summary>
        /// <param name="PackageNo"></param>
        /// <param name="FormNo"></param>
        /// <returns></returns>
        BooleanValue<BDOs> LockPackage(string PackageNo, string FormNo,string LockReason);

        /// <summary>
        /// 包装解除锁定
        /// </summary>
        /// <param name="PackageNo"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UnpackLockPackage(string PackageNo);

        /// <summary>
        /// 单件出箱
        /// </summary>
        /// <param name="PackageNo">包装号</param>
        /// <param name="Barcode">单件条码</param>
        /// <returns></returns>
        List<BDOs> OutOfPackage(string PackageNo,string Barcode);

        /// <summary>
        /// 批次出箱
        /// </summary>
        /// <param name="PackageNo">包装</param>
        /// <param name="Quantity">数量</param>
        /// <returns></returns>
        List<BDOs> OutOfPackage(string PackageNo, decimal Quantity);


        /// <summary>
        /// 单件入箱
        /// </summary>
        /// <param name="SourcePackageNo">来源包装号</param>
        /// <param name="TargetPackageNo">目的包装号</param>
        /// <param name="Barcode">单件条码</param>
        /// <returns></returns>
        List<BDOs> IntoPackage(string PackageNo, string Barcode);


        /// <summary>
        /// 批次入箱
        /// </summary>
        /// <param name="SourcePackageNo">来源包装</param>
        /// <param name="TargetPackageNo"></param>
        /// <param name="Quantity"></param>
        /// <param name="NewProd_NO"></param>
        /// <param name="NewBatch_NO"></param>
        /// <returns></returns>
        List<BDOs> IntoPackage(string PackageNo, decimal Quantity, string NewProd_NO, string NewBatch_NO);


        /// <summary>
        ///  包装变更记录
        /// </summary>
        /// <param name="model">包装变更实体</param>
        /// <returns></returns>
        BooleanValue<BDOs> CreatePackageChange(PackageChangeModel model);



        /// <summary>
        ///  新增包装条码绑定关系
        /// </summary>
        /// <param name="PackageNo">包装</param>
        /// <param name="Barcode">条码</param>
        /// <returns></returns>
        List<BDOs> AddPackageBarcode(string PackageNo, decimal Capacity, string Barcode,string Source_No="");

        /// <summary>
        /// 批量新增包装条码绑定关系
        /// </summary>
        /// <param name="PackageNo"></param>
        /// <param name="Capacity"></param>
        /// <param name="Barcodes"></param>
        /// <param name="Source_No"></param>
        /// <returns></returns>
        List<BDOs> AddPackageBarcode(string PackageNo, decimal Capacity, List<string> Barcodes, string Source_No = "");


        /// <summary>
        /// 删除包装条码绑定关系
        /// </summary>
        /// <param name="PackageNo"></param>
        /// <param name="Barcode"></param>
        /// <returns></returns>
        List<BDOs> DeletePackageBarcode(string PackageNo, string Barcode,string Source_No="");




        /// <summary>
        /// 拆箱
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SplitPackage(PackageEntity entity,bool IsCheck =true);


        /// <summary>
        ///  装箱
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ResponseStatusModel<string> LoadingPackage(PackageEntity entity,bool IsCheck =true);




        /// <summary>
        ///  打散
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ResponseStatusModel<string> BreakUpPackage(PackageEntity entity , bool IsCheck = true);




        /// <summary>
        /// 单件移除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ResponseStatusModel<string> RemoveProductSn(PackageEntity entity, bool IsCheck = true);



        /// <summary>
        /// 合箱
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ResponseStatusModel<string> PackagePutTogether(PackageEntity entity,bool IsCheck = true);

        /// <summary>
        /// 获取单件条码
        /// </summary>
        /// <returns></returns>
        BooleanValue<DataTable> GetProductSn();


        /// <summary>
        /// 获取新包装编号
        /// </summary>
        /// <returns></returns>
        ResponseStatusModel<string> GetNewPackageNo();

        /// <summary>
        /// 获取包装打印信息
        /// </summary>
        /// <returns></returns>
        ResponseStatusModel<string> GetPackagePrintMessage(string PackageNo,decimal QTY = 0);


        /// <summary>
        /// 新增条码来源表 + 条码表
        /// </summary>
        /// <param name="SourceBarcode"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateBarcodeSource(SourceBarcodeEntity SourceBarcode);


        /// <summary>
        /// 新增条码来源表 + 条码表(批次)
        /// </summary>
        /// <param name="SourceBarcode"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateBarcodeSourceInBatch(SourceBarcodeEntity SourceBarcode);


        /// <summary>
        /// 没有箱条码创建包装
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreatePackageInNoPackageNo(List<PackageModel> list);

    }
}
