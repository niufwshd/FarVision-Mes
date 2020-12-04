using System;
using System.Collections.Generic;
using System.Text;
using WebMES.DTO.Device;
using YueMES.Base.Utils;

namespace WebMES.Service.Interface.Device
{
    public interface IDeviceStatusService
    {

        BooleanResult ChangeDevRunStatus(List<DeviceRunStatus> runStatus);
    }
}
