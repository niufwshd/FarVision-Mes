using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.DTO.SysData
{
    [Serializable]
    //导入数据预览
    public class ImportViewResultDto
    {

        public bool IsSuccess { get; set; }
        public List<GridColDef> colDefs { get; set; }

        public List<string> lstMO { get; set; }

        public string jsonData { get; set; }

        public ImportViewResultDto()
        {
            colDefs = new List<GridColDef>();
            lstMO = new List<string>();
            IsSuccess = true;
        }
    }

    [Serializable]
    public class GridColDef
    {
        public string field { get; set; }
        public string displayName { get; set; }

        public string cellFilter { get; set; }
        public bool pinnedLeft { get; set; }

        public bool enablePinning { get; set; }
        public bool hidePinLeft { get; set; }
        public bool hidePinRight { get; set; }
        public bool cellTooltip { get; set; }
        public bool visible { get; set; }

        public int width { get; set; }

        public string type { get; set; }

        public GridColDef()
        {
            visible = true;
        }
    }

}
