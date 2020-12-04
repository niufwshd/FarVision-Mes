using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WebMES.Model.Data;
using WebMES.Model.SCMModels.Model.ResponseModels;
using YueMES.Base.Utils;

namespace WebMES.Business.ExtInterface.WareHouseManage.SCM2MESInterface
{
        public interface IMES2ERPResponse
        {
        /// <summary>
        /// <summary>
        //  发送http请求到erp
        /// </summary>
        /// <param name="InterfaceCode"></param>
        /// <param name="InterfaceName"></param>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SendResponse2ERP(string type, object postObj);


        ResponseStatusModel<string> SendResponse2ERP<T>(string type, T postObj);
      }
}