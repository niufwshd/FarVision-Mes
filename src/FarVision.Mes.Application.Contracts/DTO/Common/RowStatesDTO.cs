using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WebMES.DTO.Common
{

    [DataContract]
    [ProtoContract,KnownType(typeof(StateInfo))]
    public class RowStatesDTO
    {

        [DataMember]
        [ProtoMember(1)]
        public string BusiNo = "";
        [DataMember]
        [ProtoMember(2)]
        public string KeyFieldName = "ID";
        [DataMember]
        [ProtoMember(3)]
        public List<StateInfo> RowsStates = null;
        [DataMember]
        [ProtoMember(4)]
        public string ParentTableName = "";
        [DataMember]
        [ProtoMember(5)]
        public string ParentKey = "";

        [DataMember]
        [ProtoMember(6)]
        public string ChildKey = "";

        public RowStatesDTO()
        {
            RowsStates = new List<StateInfo>();
        }

        public static void CreateRelations(List<RowStatesDTO> lstRowStates,DataSet ds)
        {
            if (lstRowStates.Count == 1) return;
            foreach (var v in lstRowStates)
            {
                if (string.IsNullOrEmpty(v.ParentTableName) || string.IsNullOrEmpty(v.ParentKey)) continue;
                DataColumn dcChild = ds.Tables[v.BusiNo].Columns[v.ChildKey];
                DataColumn dcParent=ds.Tables[v.ParentTableName].Columns[v.ParentKey];
                ds.Relations.Add(dcParent, dcChild);
            }
        }

    }

    [DataContract]
    [ProtoContract]
    public class StateInfo
    {
        public StateInfo()
        {
            ColsInfos = new List<ColInfo>();
        }
        [DataMember]
        [ProtoMember(1)]
        public int RowID;
        [DataMember]
        [ProtoMember(2)]
        public DataRowState RowState=DataRowState.Unchanged;
        [DataMember]
        [ProtoMember(3)]
        public List<ColInfo> ColsInfos;

    }
    [DataContract]
    [ProtoContract]
    public class ColInfo
    {
        [DataMember]
        [ProtoMember(1)]
        public string FieldName;
        [DataMember]
        //old# [ProtoMember(2, DynamicType = true)]
        [ProtoMember(2)]
        public object OldValue;
    }

}
