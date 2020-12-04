using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model.SCMModels.Model.ResponseModels
{
    public class ReceiveGoodsResponseModel
    {

        public string Authorization { get; set; }
        public List<ReceiveGoodsItem> Data { get; set; }
    }

    public class ReceiveGoodsItem
    {
        public string Bih_No { get; set; }
        public int Bib19 { get; set; }
        public int Bib16 { get; set; }
        public int Bib26 { get; set; }
        public int Bib23 { get; set; }
    }
}
