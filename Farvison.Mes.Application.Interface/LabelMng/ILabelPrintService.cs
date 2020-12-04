using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.LabelMng
{
    public interface ILabelPrintService
    {
        /// <summary>
        /// 创建批次条码
        /// </summary>
        /// <param name="dtBarSource"></param>
        /// <param name="isChangeMaxSN"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateBatchBarcode(DataTable dtBarSource,bool isChangeMaxSN);

        /// <summary>
        /// 创建包装箱条码
        /// </summary>
        /// <param name="dtBarSource"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreatePackageBarcode(DataTable dtBarSource, bool isChangeMaxSN);

        string GetLabelPrintBillNoID(string srcType);

    }
}
