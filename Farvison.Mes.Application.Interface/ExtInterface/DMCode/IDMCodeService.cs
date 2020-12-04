using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebMES.Service.Interface.ExtInterface.DMCode
{
    /// <summary>
    /// 二维码打码服务
    /// </summary>
    public interface IDMCodeService 
    {
        /// <summary>
        /// 获取二维码
        /// </summary>
        /// <param name="prdMod"></param>
        /// <param name="sebNo"></param>
        /// <returns></returns>
        dynamic GetDataMatrixCode(string prdMod, string sebNo);

        /// <summary>
        /// 获取指定数量的二维码
        /// </summary>
        /// <param name="prdMod"></param>
        /// <param name="sebNo"></param>
        /// <returns></returns>
        dynamic GetDataMatrixCodeBatch(string prdMod, string sebNo,int qty=1);

        /// <summary>
        /// 二维码打完后返回验证，回写二维码状态
        /// </summary>
        /// <param name="dmCode"></param>
        /// <returns></returns>
        string SetBarcodeStatus(string dmCode);

        /// <summary>
        /// 一维码验证
        /// </summary>
        /// <param name="prdMod"></param>
        /// <param name="sebNo"></param>
        /// <param name="prd_snm"></param>
        /// <param name="mod_sufixx"></param>
        /// <param name="id_no"></param>
        /// <returns></returns>
        BooleanValue<DataTable> CheckData(string prdMod, string sebNo);


         BooleanValue<string> CreateBarCode(string RuleID,string Variable, DateTime BarcodeDate);


        /// <summary>
        /// 二维码过点并报工
        /// </summary>
        /// <param name="barcode"></param>
        /// <param name="processNo"></param>
        /// <returns></returns>
        Task<BooleanResult> BarCodeCheckPass(string barcode,string processNo,string devNo,string stationNo, string barcodePkgNo=null);
        
    }
}
