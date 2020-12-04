using YueMES.Base.Utils;
using WebMES.Model.Production;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Service.Interface.Production.Transport
{
    public interface ITransportService
    {
        /// <summary>
        /// 查询熔炼为最早的且没有转运完成的
        /// </summary>
        /// <returns></returns>
        BooleanValue<DataTable> GetTransportRLByDate();


        /// <summary>
        ///转运(精炼)保存
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanResult SaveTransportRefine(Transport_Refine model);

        /// <summary>
        ///删除备件信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanResult DeleteSparePart(string ids);

        /// <summary>
        ///统计领料单依据品号,工序,时间
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<DataTable> GetHistoryMaterialByPRDT(HistoryMaterial model);


        /// <summary>
        /// 查询炉批号是否投料
        /// </summary>
        /// <returns></returns>
        BooleanValue<DataTable> GetBlowingINByRLID(int RLID);

        /// <summary>
        /// 查询开炉历史记录
        /// </summary>
        /// <returns></returns>
        BooleanValue<DataSet> GetBlowingINHistory(RL_SBEI model);

        /// <summary>
        /// 删除开炉历史记录
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        BooleanResult DeleteBlowingINHistory(string ids);

        /// <summary>
        /// 查询投料熔炼历史
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<DataTable> ProductionFeedRLHistory(RL_SBEI model);

        /// <summary>
        /// 熔炼初始化
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<DataSet> GetPrdTransportRLForInit(RL_SBEI model);

        BooleanResult DeletePdTransportHistory(string ids);

        /// <summary>
        /// 精炼初始化
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        BooleanValue<DataSet> GetPrdTransportJLForInit(RL_SBEI model);

        /// <summary>
        /// 查询精炼历史
        /// </summary>
        BooleanValue<DataSet> GetPdTransportJLHistory(RL_SBEI model);

        
        /// <summary>
        /// 删除精炼历史
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        BooleanResult DeletePdTransportJLHistory(string ids);



        /// <summary>
        /// 存储过程生成熔炼炉号
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        BooleanValue<DataSet> GetBlowingINRLCODE(RL_SBEI model);


        /// <summary>
        /// 存储过程生成精炼炉号
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        BooleanValue<DataSet> GetRefiningCODE(RL_SBEI model);
    }
}
