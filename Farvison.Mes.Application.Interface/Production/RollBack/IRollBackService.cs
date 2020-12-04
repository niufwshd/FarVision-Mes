using YueMES.Base.Utils;
using YueMES.Data.Utils;
using WebMES.Model.Production;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Production.RollBack
{
    public interface IRollBackService
    {
        /// <summary>
        /// 产生当前工序,过点工序，前道工序的相关报工单数量扣减，以及工单数量扣减
        /// </summary>
        /// <param name="rollBackInfo"></param>
        /// <param name="tzUpdSql"></param>
        /// <returns></returns>
         BooleanValue<BDOs> CreateRollBackWorkReport(PDRollBackModel rollBackInfo, out string tzUpdSql);

        /// <summary>
        /// 产生前道工序的不合格处理单
        /// </summary>
        /// <param name="rollBackInfo"></param>
        /// <param name="wrNo"></param>
        /// <returns></returns>
         BooleanValue<BDOs> CreateRollBackZCDSP(PDRollBackModel rollBackInfo, string wrNo,string prdNo);


        
        
    }
}
