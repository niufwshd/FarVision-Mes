using System;
using System.Collections.Generic;
using System.Text;
using WebMES.DTO.Device;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.ExtInterface.Device
{
    public interface IDeviceExtService
    {
        /// <summary>
        /// 设备状态变更
        /// </summary>
        /// <param name="devNo"></param>
        /// <param name="statusNo"></param>
        /// <returns></returns>
        BooleanResult UpdateDevRunStatus(List<DeviceRunStatus> lstStatus);

        /// <summary>
        /// 设备报警
        /// </summary>
        /// <param name="devNo"></param>
        /// <param name="alertNo"></param>
        /// <param name="alertName"></param>
        /// <returns></returns>
        BooleanResult DevAlert(List<DeviceAlertInfoDto> lstAlert);

    }
}
