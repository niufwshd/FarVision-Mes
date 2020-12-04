using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Device
{
    [Serializable]
    public class DeviceAlertInfoDto
    {

        public string devNo { get; set; }
        public string alertNo { get; set; }
        public string alertDesc { get; set; }
    }

 
}
