using System.Data;
using WebMES.Model.Production;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.Quality
{
    public interface ISpectrumService
    {
        /// <summary>
        /// 获取光谱检验结果
        /// </summary>
        /// <param name="ZC_N0">工序</param>
        /// <param name="GPBAT_NO">光谱批号</param>
        /// <returns></returns>
        BooleanValue<DataTable> GetSBRecord(string ZC_N0,string GPBAT_NO );

        /// <summary>
        /// 获取光谱检验结果
        /// </summary>
        /// <param name="ZC_N0">工序</param>
        /// <param name="GPBAT_NO">光谱批号</param>
        /// <returns></returns>
        BooleanValue<DataSet> GetSpectrum(RL_SBEI model);

        /// <summary>
        /// 异常处理
        /// </summary>
        /// <param name="ZC_N0">工序</param>
        /// <param name="GPBAT_NO">光谱批号</param>
        /// <returns></returns>
        BooleanResult ExceptionHandling(RL_SBEI model);

        /// <summary>
        /// 获取光谱检验结果
        /// </summary>
        /// <param name="ZC_N0">工序</param>
        /// <param name="GPBAT_NO">光谱批号</param>
        /// <returns></returns>
        BooleanValue<DataSet> GetExperimentalRecordInit(RL_SBEI model);
    }
}
