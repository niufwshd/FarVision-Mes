using YueMES.Base.Utils;
using YueMES.Data.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMES.Model.Production;
using WebMES.Model.Quality;

namespace WebMES.Service.Interface.Quality.UnQuality
{
    public interface IUnqualityService
    {
        /// <summary>
        /// 获取不合格条码相关信息
        /// </summary>
        /// <param name="barCode"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetUnqualityBarInfo(string barCode);

        BooleanResult CreateUnqualityBill(string oldZCNO, dynamic vZCDSPInfo);

        /// <summary>
        /// 新增过点
        /// </summary>
        /// <param name="barCode"></param>
        /// <param name="zcNo"></param>
        /// <param name="vZCDSPInfo"></param>
        /// <returns></returns>
        BooleanValue<BDOs> checkAndCreateBarPass(string barCode, string zcNo, dynamic vZCDSPInfo);

        BooleanValue<BDOs> createWorkReport(string barCode, dynamic vZCDSPInfo, BDO bdoTZ, int pn, out string tzUpdSql);

      /// <summary>
      /// 根据不合格缺陷生成不合格处理单
      /// </summary>
      /// <param name="defInfo"></param>
      /// <param name="tzInfo"></param>
      /// <returns></returns>
        BooleanValue<BDOs> CreateUnqualityWithDefInfo(dynamic defInfo, dynamic tzInfo);


        /// <summary>
        /// 根据扫码缺陷生产不合格处理单--新表
        /// </summary>
        /// <param name="codeLst"></param>
        /// <param name="wkCenter">工作中心号</param>
        /// <param name="srcNo">来源单</param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateUnqualityBill(List<BarCodeModel> codeLst,string srcNo);




        /// <summary>
        ///创建 不合格处理单
        /// </summary>
        /// <param name="codeLst"></param>
        /// <param name="wkCenter">工作中心号</param>
        /// <param name="srcNo">来源单</param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateUnAcceptHandleModel(UnAcceptedHandleModel model);



    }
}
