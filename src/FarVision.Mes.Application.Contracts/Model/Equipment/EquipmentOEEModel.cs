using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Equipment
{
    public class EquipmentOEEModel
    {
      public int OEEID { get; set; }
      public string OEEDate { get; set; }
      public string EquipmentName { get; set; }
      public decimal PlanWH { get; set; } //计划生产时间
      public decimal EffectiveWH { get; set; } //有效生产时间
      public decimal FaultWH { get; set; }
      public decimal NoFaultWH { get; set; }
      public decimal TimeAVA { get; set; }//时间开动率
      public decimal ActualP { get; set; }  //实际生产量
      public decimal TheoreticalP { get; set; } //理论生产量
      public decimal PerformanceAVA { get; set; } //性能开动率
      public decimal QualifiedNum { get; set; }   
      public decimal ProductionNum { get; set; }
      public decimal QualifiedRate { get; set; }//合格率
      public decimal OEE { get; set; }
    }
    
    
}
