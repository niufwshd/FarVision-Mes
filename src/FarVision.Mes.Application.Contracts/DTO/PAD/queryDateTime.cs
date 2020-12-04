using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMES.DTO.PAD
{
     public class queryDateTime
    {
         public DateTime dtStart{get;set;}
         public DateTime dtEnd{get;set;}

         public queryDateTime()
         {
             dtStart = DateTime.Now.Date;
             dtEnd = DateTime.Now.Date;
         }

    }
}
