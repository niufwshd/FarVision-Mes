using System;
using System.Collections.Generic;
using System.Text;
using WebMES.Model.Mold;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.Molds.MoldMng
{
    public interface IMoldMngService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        BooleanValue<List<BDOs>> ChangeMoldWhseStatus(List<MoldWhseModel> moldList);



        BooleanValue<List<BDOs>> RollBackMoldWhseStatus(List<MoldWhseModel> moldList);

        /// <summary>
        /// 更改自动报工里的模具信息
        /// </summary>
        /// <param name="changInfo"></param>
        /// <returns></returns>
        BooleanResult ChangeOutputMoldNo(MoldChangeInfo changInfo);
        
    }
}
