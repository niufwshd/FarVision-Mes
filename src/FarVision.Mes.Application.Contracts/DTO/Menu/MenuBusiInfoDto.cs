using System.Collections.Generic;

namespace WebMES.DTO.Menu
{
    public class MenuBusiInfoDto
    {
        public int menuID { get; set; }
        public string captionExp { get; set; }
        public string busiNoExp
        {
            get;
            set;
        }
        public List<string> busiNos { get; set; }

        public MenuBusiInfoDto()
        {
            busiNos = new List<string>();
        }
    }
}
