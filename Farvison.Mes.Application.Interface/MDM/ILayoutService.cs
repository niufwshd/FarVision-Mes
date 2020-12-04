using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;
using WebMES.Model.Data;

namespace WebMES.Service.Interface.MDM
{
   public interface ILayoutService
    {
        /// <summary>
        /// 增加工厂布局
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateLayout(dynamic info);
        /// <summary>
        /// 修改工厂布局
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateLayout(dynamic info);

        /// <summary>
        /// 删除工厂布局 ISDELETE逻辑删除
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        ResponseStatusModel<string> DeleteLayout(dynamic info);

        /// <summary>
        /// 属性明细
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> EditAttributeValue(List<dynamic> info);

        /// <summary>
        /// 删除属性 ISDELETE 逻辑删除
        /// </summary>
        /// <param name="ObjectCode">  对象编号（工厂code，仓库code等）</param>
        /// <returns></returns>
        BooleanValue<BDOs> DeleteAttributeValue(string ObjectCode);

    }
}
