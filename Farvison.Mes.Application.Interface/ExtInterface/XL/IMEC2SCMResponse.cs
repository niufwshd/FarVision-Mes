
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
        public interface IMEC2SCMResponse
        {

        /// <summary>
        ///SCM POST请求
        /// </summary>
        /// <param name="InterfaceCode"></param>
        /// <param name="InterfaceName"></param>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SCMPostResponse<T>(string InterfaceCode, string InterfaceName, T postObj);

        /// <summary>
        ///SCM PUT请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="InterfaceCode"></param>
        /// <param name="InterfaceName"></param>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> SCMPutResponse<T>(string InterfaceCode, string InterfaceName, T postObj);
       



        /// <summary>
        /// U9成品入库单接口
        /// </summary>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> ReceiveGoodsBillResponse(string InterfaceCode, string InterfaceName, object postObj);
        /// <summary>
        /// MES2SCM到货复检接口
        /// </summary>
        /// <param name="InterfaceCode"></param>
        /// <param name="InterfaceName"></param>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> ReCheckMaterial2SCM(string InterfaceCode, string InterfaceName, object postObj);

        /// <summary>
        /// MES2SCM到货收货接口
        /// </summary>
        /// <param name="InterfaceCode"></param>
        /// <param name="InterfaceName"></param>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> ReceiveGoods2SCM(string InterfaceCode, string InterfaceName, object postObj);

        /// <summary>
        /// MES2SCM到货退货接口
        /// </summary>
        /// <param name="InterfaceCode"></param>
        /// <param name="InterfaceName"></param>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> ReturnGoods2SCM(string InterfaceCode, string InterfaceName, object postObj);


        /// <summary>
        /// 工单接口
        /// </summary>
        /// <param name="InterfaceCode"></param>
        /// <param name="InterfaceName"></param>
        /// <param name="postObj"></param>
        /// <returns></returns>
        ResponseStatusModel<string> WorkOrder2SCM(string InterfaceCode, string InterfaceName, object postObj);
    }
}