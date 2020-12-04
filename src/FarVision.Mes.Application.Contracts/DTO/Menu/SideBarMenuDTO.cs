using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.Menu
{
     [DataContract]
    public class SideBarMenuDTO
    {

        [DataMember]
        [Description("ID")]
        public int ID { get; set; }

         [DataMember]
        public string No { get; set; }

        [DataMember]
        public string BusiNo { get; set; }

        [DataMember]
        public string QueryNo { get; set; }

        [DataMember]
        [Description("菜单Icon")]
        public string BSImg { get; set; }
        [DataMember]
        [Description("菜单名称")]
        public string Caption { get; set; }

        [DataMember]
        [Description("类名")]
        public string ClassName { get; set; }
        

        [DataMember]
        [Description("菜单Url")]
        public string BSUrl { get; set; }
        [DataMember]
        [Description("菜单参数")]
        public string Params { get; set; }
        [DataMember]
        [Description("子菜单")]
        public List<SideBarMenuDTO> SubMenus { get; set; }
        [DataMember]
        [Description("父菜单")]
        public string ParentMenuNo { get; set; }
    }
}
