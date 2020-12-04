using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Production
{

    /// <summary>
    /// 装箱批次信息
    /// </summary>
    [Serializable]
    public class BoxingBatchInfoDto
    {

        public string prodNo { get; set; }
        public string woNO { get; set; }

        public string processNo { get; set; }
        public string batchNo { get; set; }

        public string result { get; set; }
        public string storageType { get; set; }

        public string unit { get; set; }

        public string Remark { get; set; }

    }
}
