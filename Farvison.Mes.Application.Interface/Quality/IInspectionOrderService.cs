using System;
using System.Collections.Generic;
using System.Text;
using WebMES.Model.Quality;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Quality
{
    /// <summary>
    /// 检验单接口
    /// </summary>
    public interface IInspectionOrderService
    {
        /// <summary>
        /// 创建检验单
        /// </summary>
        /// <param name="bDOs">送检单</param>
        /// <returns></returns>
        BooleanResult CreateInspectingOrder(BDOs bDOs, int solutionID = 0);

        /// <summary>
        /// 录入检验值
        /// </summary>
        /// <returns></returns>
        BooleanResult InputInspectValue(List<RecordValue> recordValues, bool isSubmit);

        BooleanResult CheckSample(string sourceBillNo);

        BooleanResult Delete(int id);

    }
}
