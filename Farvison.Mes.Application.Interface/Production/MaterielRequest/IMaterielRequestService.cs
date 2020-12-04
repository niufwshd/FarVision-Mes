using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;
using WebMES.Model.WareHouse;
using System.Linq.Expressions;
using WebMES.Model.Production;
using WebMES.Model.Data;

namespace WebMES.Service.Interface.Production.MaterielRequest
{
    public interface IMaterielRequestService
    {

        /// <summary>
        /// 新增物料拉动请求
        /// </summary>
        /// <param name="materialRequest">物料拉动请求</param>
        BooleanValue<BDOs> AddMaterialRequest(MaterielRequestModel materialRequest);

        /// <summary>
        /// 修改物料拉动请求
        /// </summary>
        /// <param name="materialRequest">物料拉动请求</param>
        BooleanValue<BDOs> UpdateMaterialRequest(MaterielRequestModel materialRequest);

        /// <summary>
        /// 修改物料拉动请求 状态
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateMaterialRequestStatus(int id, string status);

        /// <summary>
        /// 删除物料拉动请求
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> RemoveMaterialRequest(int id);

        /// <summary>
        /// 物料呼叫
        /// </summary>
        /// <param name="id">唯一编号</param>
        BooleanValue<BDOs> CallMaterial(MaterielRequestModel materialRequest);


        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ResponseStatusModel<string> CancelMaterialRequest(int id);

        /// <summary>
        /// 完成
        /// </summary>
        /// <param name="id"></param>
        BooleanValue<BDOs> FinishMaterialRequest(int id);

        /// <summary>
        ///  根据工位获取产线下的所有工位
        /// </summary>
        /// <param name="WorkPosition"></param>
        /// <returns></returns>
        DataTable GetWorkPositionUp(string WorkPosition);

        /// <summary>
        /// 根据工单+物料 获取 物料拉动类型（催料还是补料）
        /// </summary>
        /// <param name="WO_NO"></param>
        /// <param name="PROD_NO"></param>
        /// <param name="Quantity"></param>
        /// <returns></returns>
        ResponseStatusModel<string> GetMaterialRequestType(string WO_NO, string PROD_NO, decimal Quantity);
    }
}
