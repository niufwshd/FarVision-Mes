using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Quality
{
    //检验项目模型
    public class QualityGrades
    { /// <summary>
      ///缺陷类型+名称
      /// </summary>
        public string NAME { get; set; }

        /// <summary>
        ///缺陷类型+名称
        /// </summary>
        public string SPC_NO { get; set; }
        /// <summary>
        ///缺陷等级
        /// </summary>
        public string SPC_GRADE { get; set; }
         /// <summary>
         /// 数量
         /// </summary>
        public int QTY { get; set; }


    }
}
