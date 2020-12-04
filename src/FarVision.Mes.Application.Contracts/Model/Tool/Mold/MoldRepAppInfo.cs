using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.Tool.Mold
{
    public class MoldRepAppInfo
    {
        public string Name { get; set; }
        public string Usr_Exec { get; set; }

        public DateTime App_Date { get; set; }

        public string Dept { get; set; }
        public string BilType { get; set; }

        public string Src_No { get; set; }

        public string Src_Type { get; set; }

        public string RepairType { get; set; }

        public string Status { get; set; }

        public List<MoldRepAppItem> AppItems { get; private set; }

        public MoldRepAppInfo()
        {
            AppItems = new List<MoldRepAppItem>();
            App_Date = DateTime.Now;

            Status = "ready";

            RepairType = "Inner";
        }


    }

    public class MoldRepAppItem
    {
        public string Mod_No { get; set; }

        public string Mod_SN { get; set; }

        public string PartNo { get; set; }

        public int Qty { get; set; }

    }
}
