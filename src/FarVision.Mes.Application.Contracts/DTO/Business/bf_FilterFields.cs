using WebMES.DTO.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.Business
{
    [DataContract]
    public class bf_FilterFields
    {
         [DataMember]
        public string FieldName_Key { get; set; }
         [DataMember]
        public string FieldName { get; set; }
         [DataMember]
        public string FieldCaption { get; set; }
         [DataMember]
        public string OwnerAlias { get; set; }
        public string OwnerCaption { get; set; }
        [DataMember]
        public string BusiNo { get; set; }
        [DataMember]
        public int DbType { get; set; }

        [DataMember]
        public string gc_Format { get; set; }

        [DataMember]
        public int edit_Type { get; set; }

        [DataMember]
        public string edit_No { get; set; }

        [DataMember]
        public string edit_Field { get; set; }

        [DataMember]
        public string edit_Condition { get; set; }
        [DataMember]
        public bool edit_Multiselect { get; set; }

        [DataMember]
        public string edit_DisplayField { get; set; }
         
        [DataMember]
        public List<bf_ComboxItemDTO> comboxItems { get; set; }
    }
}
