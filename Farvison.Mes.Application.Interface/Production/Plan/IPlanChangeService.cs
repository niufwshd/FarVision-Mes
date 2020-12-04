using System;
using System.Collections.Generic;
using System.Text;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Production.Plan
{

    /// <summary>
    /// 生产计划变更相关
    /// </summary>
    public interface IPlanChangeService
    {
        /// <summary>
        /// 工单重新派工(删掉已经排产的再派工，需更新已报工的报工信息，回写新工单的报工数量)
        /// </summary>
        /// <param name="bdosOrder">新派工的工单信息</param>
        /// <returns></returns>
        BooleanResult OrderReSched(BDOs bdosOrder);
    }
}
