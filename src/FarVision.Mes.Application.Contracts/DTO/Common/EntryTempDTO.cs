using System;
using System.Runtime.Serialization;

namespace WebMES.DTO.Common
{
    [DataContract]
    [Serializable]
    public class EntryTempDTO
    {
        public EntryTempDTO() { }
        public EntryTempDTO(string _EntryID, int _InOut)
        {
            EntryID = _EntryID;
            ActType = _InOut;
        }

        [DataMember]
        public  string EntryID = null;
        [DataMember]
        public int IncludeTP = 0; //0;所有条码；1-仅一般条码，2-仅托盘条码
        [DataMember]
        public string Barcode = null;
        [DataMember]
        public  int ActType = -1; //0-进。1-出
        [DataMember]
        public string CreateUserID = null;
        [DataMember]
        public string UserMac = null;
        [DataMember]
        public string SourceBarCode = null; //原条码或托盘条码
        [DataMember]
        public string BusiClassName = null;
        [DataMember]
        public string billNO = null;//来源单号
        [DataMember]
        public string billType = null;//来源单据类别
        [DataMember]
        public string WHNO = null;    //仓库
        [DataMember]
        public string StorageNO = null;     //储位
        [DataMember]
        public string IDNO = null;   //扫描单号
        [DataMember]
        public string SubmitFlg = null;   //扫描标记
        [DataMember]
        public decimal QTY_Deduction = 0; //条码表调减数量(要减去的)
        [DataMember]
        public decimal QTY_Out = 0;      //条码出库数量，为0则为条码数量
        [DataMember]
        public bool FIFOCheck = false;
        [DataMember]
        public string CUS_NO = null; //出货客户
    }
}
