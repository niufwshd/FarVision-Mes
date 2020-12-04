using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Mold
{
    public class MoldChangeInfo
    {
        /// <summary>
        /// 当前模具
        /// </summary>
        public string CurMoldNo { get; set; }

        /// <summary>
        /// 上次模具
        /// </summary>
        public string LastMoldNo { get; set; }

        /// <summary>
        /// 当前工位
        /// </summary>
        public string CurStationNo { get; set; }

        /// <summary>
        /// 上次工位
        /// </summary>
        public  string LastStationNo { get; set; }

        /// <summary>
        /// 本次换模结束时间
        /// </summary>
        public DateTime ChangeEnd { get; set; }

        /// <summary>
        /// 本次操作时间
        /// </summary>
        public DateTime OpDatetime { get; set; }
    }
}
