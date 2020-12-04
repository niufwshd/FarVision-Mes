using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Quality
{
   public interface IQaInspectionService
    {
        /// <summary>
        /// 获取首末巡检验表单
        /// </summary>
        /// <param name="ZC_N0">工序</param>
        /// <param name="PRD_NO">品号</param>
        /// <param name="QaType">检验类型(首、末、巡)</param>
        /// <returns></returns>
        BooleanValue<DataTable> GetPRD_SQC(string ZC_N0,string PRD_NO,string QaType);

       /// <summary>
       /// 根据条件取检验项目
       /// </summary>
       /// <param name="prdNo">品号</param>
       /// <param name="zcNo">工序</param>
        /// <param name="prjCategory">方案类型</param>
        /// <param name="prjType">检验类别</param>
        /// <param name="prjFeature">送检/自检</param>
       /// <returns></returns>
       BooleanValue<DataTable> GetInspItems(string prdNo,string zcNo,string prjCategory,string prjType,string prjFeature);
    }
}
