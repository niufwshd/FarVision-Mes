using System.Collections.Generic;
using System.Data;
using WebMES.Model.Production;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Production.Barcode
{
    public interface IBarcodeScanService
    {

        /// <summary>
        /// 条码验证
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
         BooleanValue<dynamic>  CheckBarCode(BarCodeModel code);

        /// <summary>
        /// 条码过点到临时表
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
       //  BooleanValue<dynamic> BarCodePass(BarCodeModel code);

        /// <summary>
        /// 获取临时表条码信息，用于页面扫码信息恢复
        /// </summary>
        /// <param name="tzNO"></param>
        /// <param name="usrNo"></param>
        /// <param name="sebNo"></param>
        /// <param name="zcNo"></param>
        /// <returns></returns>
         BooleanValue<dynamic> GetTempBarInfo(string tzNo,string usrNo,string sebNo,string zcNo);


        /// <summary>
        /// 写入临时表
        /// </summary>
        /// <param name="codeLst"></param>
        /// <returns></returns>
        BooleanValue<BDOs> WriteBarScanTemp(List<BarCodeModel> codeLst);

        /// <summary>
        /// 条码过点信息创建
        /// </summary>
        /// <param name="codeLst"></param>
        /// <param name="inOut">进出标志:in,out</param>
        /// <returns></returns>
        BooleanValue<BDOs> BarCodePass(List<BarCodeModel> codeLst,string  inOut);

        
        /// <summary>
        /// 取扫码相机条码
        /// </summary>
        /// <param name="sebNo">设备号</param>
        /// <param name="qty">条码梳理</param>
        /// <param name="passImmediate">是否立即过点</param>
        /// <param name="prdNo">品号</param>
        /// <returns></returns>
        BooleanValue<DataTable> getAutoScanBarData(string sebNo, int qty, bool passImmediate, out string updStql, string prdNo = null);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rptNo">报工单号</param>
        /// <returns></returns>
        BooleanResult RemoveWorkReportBarcode(string rptNo);


        /// <summary>
        /// 针对合格条码创建包装信息
        /// </summary>
        /// <param name="EntryID"></param>
        /// <param name="Capacity">容量</param>
        /// <param name="IsForce">未满箱是否强制装箱</param>
        /// <returns></returns>
        BooleanValue<List<BDOs>> CreatePackage(string EntryID,string woNo, int Capacity,bool IsForce,ref string pkgNo,out List<BarCodeModel> codeLst);

        BooleanValue<List<BDOs>> CreatePackage(List<BarCodeModel> codeLst, int Capacity, bool IsForce, ref string pkgNo);

        List<BarCodeModel> GetBarcodeTempInfo(string EntryID, string woNo);

        List<BarCodeModel> GetBarcodeTempInfo(string EntryID, string woNo,int okCount);

        /// <summary>
        /// 取所有未出到下工序的已扫条码
        /// </summary>
        /// <param name="processNo"></param>
        /// <param name="stationNo"></param>
        /// <param name="userNo"></param>
        /// <returns></returns>
        List<BarCodeModel> GetBarcodeTempInfo(string processNo,string stationNo,string userNo);


        List<BarCodeModel> GetBarcodeTempInfo(string filter,int rowsCount=-1);

        /// <summary>
        /// 缺陷条码临时表信息写入
        /// </summary>
        /// <param name="BarModel"></param>
        /// <returns></returns>
        BooleanValue<int> ChangeDefectBarcodeTempInfo(BarCodeModel BarModel);

        /// <summary>
        /// 删除临时表信息，删除接收状态
        /// </summary>
        /// <param name="BarModel"></param>
        /// <returns></returns>
        BooleanResult RemoveTempBarcodeInfo(string barcode);

        BooleanResult CheckSingleBarcode(List<bindingInfo> barcode);

        /// <summary>
        /// 总成码验证
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        BooleanResult CheckIntegBarcode(bindingInfo barcode);
        

        
    }
}
