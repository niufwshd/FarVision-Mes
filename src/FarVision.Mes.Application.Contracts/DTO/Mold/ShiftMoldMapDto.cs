using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.Mold
{
    /// <summary>
    /// 排产班次对应模具
    /// </summary>
    public class ShiftMoldMapDto
    {
        /// <summary>
        /// 当前班次
        /// </summary>
        public string curShiftNo { get; set; }
        /// <summary>
        /// 下一班次
        /// </summary>
        public string nextShiftNo { get; set; }

        /// <summary>
        /// 当前班次模具列表
        /// </summary>
        public List<MoldLayoutInfo> curMoldList { get; set; }

        /// <summary>
        /// 下一班次模具列表
        /// </summary>
        public List<MoldLayoutInfo> nextMoldList { get; set; }


        public ShiftMoldMapDto()
        {
            curMoldList = new List<MoldLayoutInfo>();
            nextMoldList = new List<MoldLayoutInfo>();

        }

        
    }

    public struct MoldLayoutInfo
    {
        public string layoutNo { get; set; }

        public string moldNo { get; set; }
    }
}
