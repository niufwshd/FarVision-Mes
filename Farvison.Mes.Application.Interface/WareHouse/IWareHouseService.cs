using YueMES.Base.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using YueMES.Data.Utils;
using WebMES.Model.WareHouse;
using YueMES.Data.Services;
using WebMES.Model.Data;
using WebMES.DTO.SysData;

namespace WebMES.Service.Interface.WareHouse
{
   public interface IWareHouseService
    {
        /// <summary>
        /// 增加仓库
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> CreateWareHouse(dynamic info);
        /// <summary>
        /// 修改仓库
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        BooleanValue<BDOs> UpdateWareHouse(dynamic info);

        /// <summary>
        /// 删除仓库 ISDELETE逻辑删除
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        ResponseStatusModel<string> DeleteWareHouse(dynamic info);

        /// <summary>
        /// 根据仓库编号查询仓库信息
        /// </summary>
        /// <param name="WareHouseNO"></param>
        /// <returns></returns>
        WareHouseModel getWareHouse(string WareHouseNO);

        /// <summary>
        /// 获取所有下级仓库
        /// </summary>
        /// <param name="WareHouseNo"></param>
        /// <returns></returns>
        string GetDownWareHouse(string WareHouseNo);

        /// <summary>
        /// 先判断下是否有临时库位，没有的话 新建临时库位 规则为：仓库编号+Temp,（注：要在事物外调用）
        /// </summary>
        /// <param name="SourceWareHouseNO"></param>
        /// <returns></returns>
        DataRowSaveResult CreateWareHouseTemp(string SourceWareHouseNO);


        /// <summary>
        /// 获取工位所属产线的原料仓库
        /// </summary>
        /// <param name="WorkPosition"></param>
        /// <returns></returns>
        string GetMaterialWareHouseInWorkPosition(string WorkPosition);

        /// <summary>
        /// 仓库导入
        /// </summary>
        /// <param name="dtImportData"></param>
        /// <returns></returns>
        BooleanValue<ImportViewResultDto> WareHouseImportWithPreView(DataTable dtImportData);
    }
}
