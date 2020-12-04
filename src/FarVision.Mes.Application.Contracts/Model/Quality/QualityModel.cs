using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.Model.Quality
{

    public class QualityModel
    {
        //decimal Value1 { get; set; }
        //decimal Value2 { get; set; }
        //decimal Value3 { get; set; }
        //decimal Value4 { get; set; }
        //decimal Value5 { get; set; }
        //decimal Average { get; set; }
        //decimal Max_min { get; set; }

    }




    public class QualityXbarModel
    {
        public int rowid { get; set; }
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public decimal Value4 { get; set; }
        public decimal Value5 { get; set; }
        public decimal aver { get; set; }
        public decimal Max_min { get; set; }

        public decimal XUCL { get; set; }
        public decimal XLCL { get; set; }
        public decimal RUCL { get; set; }
        public decimal RLCL { get; set; }
        public decimal AllAverage { get; set; }
        public decimal ALLMax_Min { get; set; }

    }
    public class QualityZTFModel
    {
        public int rowid { get; set; }
        public decimal Lowerlimit { get; set; }
        public decimal Upperlimit { get; set; }
        public decimal Number { get; set; }

    }

}
