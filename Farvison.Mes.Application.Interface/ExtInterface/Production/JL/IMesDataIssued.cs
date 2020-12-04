using System;
using System.Collections.Generic;
using System.Text;
using WebMES.Model.ExtInterfaceModel.Production.JL;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.ExtInterface.Production.JL
{
    /// <summary>
    /// MES生产数据下发
    /// </summary>
    public interface IMesDataIssued
    {
        /// <summary>
        /// 下发当前工位正在执行的工单，用于铸造/机加等工序
        /// </summary>
        /// <param name="lstModel"></param>
        /// <returns></returns>
        BooleanResult WorkOrderIssued(List<WorkOrderIssuedModel> lstModel);

        /// <summary>
        /// 模具数据下发
        /// </summary>
        /// <param name="lstModel"></param>
        /// <returns></returns>
        BooleanResult MoldUseIssued(List<MoldUseIssued> lstModel);

    }
}
