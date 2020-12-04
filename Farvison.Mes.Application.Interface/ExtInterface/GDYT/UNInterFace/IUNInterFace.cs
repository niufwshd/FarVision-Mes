using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WebMES.Service.Interface.ExtInterface.UNInterFace
{
    public interface IUNInterFace
    {
        /// <summary>
        /// U9成品入库单接口
        /// </summary>
        /// <param name="postObj"></param>
        /// <returns></returns>
        BooleanResult UNInterfaceResponse(string InterfaceCode,string InterfaceName,object postObj);



    }
}
