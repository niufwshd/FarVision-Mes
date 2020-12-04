using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Device
{
    [Serializable]
    public class DeviceRunStatus
    {
      
        public string devNo { get; set; }
        public string statusNo { get; set; }
        public string propertyNo { get; set; }

    }
}
