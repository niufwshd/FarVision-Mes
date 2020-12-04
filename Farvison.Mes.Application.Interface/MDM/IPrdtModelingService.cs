using System;
using System.Collections.Generic;
using System.Text;
using WebMES.DTO.BaseData;
using YueMES.Base.Utils;
using YueMES.Data.Utils;

namespace WebMES.Service.Interface.MDM
{
    public interface IPrdtModelingService
    {

        /// <summary>
        /// 1.生成新的工艺流程，原有版本失效,原工艺流程按工序输出物生成新的工艺流程
        /// 2.生成新的BOM,原BOM失效
        /// </summary>
        /// <param name="lstMap"></param>
        /// <returns></returns>
        BooleanValue<List<BDOs>> CreateNewWorkProcessAndBOM(List<ProductProcessMapDto> lstMap);


       
    }
}
