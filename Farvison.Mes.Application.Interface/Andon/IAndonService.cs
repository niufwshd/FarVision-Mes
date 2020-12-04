using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Andon
{
    public interface IAndonService
    {

        /// <summary>
        /// 根据工位获取andon类型
        /// </summary>
        /// <param name="CallType">安灯类型</param>
        /// <param name="WorkStation">工位</param>
        /// <returns></returns>
        BooleanValue<DataTable> GetAndonType(string CallType, string WorkStation, string processNo);

        /// <summary>
        /// 根据工位获取安灯数量（安灯类型分组）
        /// </summary>
        /// <param name="WorkStation">工位</param>
        /// <returns></returns>
        BooleanValue<DataTable> GetAndonNubmer(string WorkStation, string processNo);


        BooleanValue<DataTable> GetAndonNumber(string callStatus, string workStation, string processNo);
    }
}
