using System;
using System.Collections.Generic;
using System.Text;

namespace WebMES.Model
{
    public class RecheckModelResponse
    {
        public string Authorization { get; set; }
        public List<RecheckModelResponseItem> Data { get; set; }
    }

    public class RecheckModelResponseItem
    {
       public string Bih_no { get; set; }
	   public int Bib19 { get; set; }
	   public int Bib30 { get;set;}
	   public int Bib31 { get;set;}
	   public int Bib32 { get;set;}
	   public int Bib33 { get;set;}
	   public int Sgm08{ get;set;}
	   public int Sgm09{ get;set;}
	   public int Sgm15{ get;set;}
    }
}
