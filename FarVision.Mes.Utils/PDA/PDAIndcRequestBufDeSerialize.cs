using YueMES.Base.Indc;
using YueMES.Base.Utils;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WebMES.Utils.PDA
{
    public  class IndcRequestBufDeSerialize
    {
        public static BooleanValue<IndcRequest> TranToIndcRequest(byte[] bytes, long offset, long length)
        { 
            MemoryStream memoryStream = new MemoryStream(bytes);

            IndcRequest_Buf result = ProtoBufHelper.DeSerialize<IndcRequest_Buf>(memoryStream);
            if (result != null && !string.IsNullOrEmpty(result.Command))
            {
                IndcRequest req = new IndcRequest(result.Command, result.Params.ToArray());
                return new BooleanValue<IndcRequest>(req);
            }
            return null;
        
        }


    }

    [ProtoContract]
    public class IndcRequest_Buf
    {
        [ProtoMember(1)]
        public string Command { get; set; }
        private List<object> m_Params;
        /// <summary>
        /// 请求的参数
        /// </summary>
        [ProtoMember(2)]
        public List<object> Params
        {
            get
            {
                if (this.m_Params != null) return this.m_Params;
                this.m_Params = new List<object>();
                return this.m_Params;
            }
            set { this.m_Params = value; }
        }
    
    }
}
