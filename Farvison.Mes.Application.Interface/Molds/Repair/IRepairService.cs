//using System;
//using System.Collections.Generic;
//using System.Text;
//using WebMES.Model.Tool.Mold;
//using YueMES.Base.Utils;
//using YueMES.Data.Utils;

//namespace WebMES.Service.Interface.Molds.Repair
//{
//    public interface IRepairService
//    {
//        /// <summary>
//        /// 转维修申请单
//        /// </summary>
//        /// <returns></returns>
//        BooleanValue<BDOs> ToRepairApplication(MoldRepAppInfo repAppInfo);

//        /// <summary>
//        /// 更新维修申请行状态
//        /// </summary>
//        /// <param name="AppNo">申请单号</param>
//        /// <param name="IDList">行项目ID列表</param>
//        /// <param name="status">0-准备，1-已派工</param>
//        /// <returns></returns>
//        BooleanValue<BDOs> UpdateRepairApplicationItemStatus(string AppNo,List<string> IDList,string status);
//    }
//}
