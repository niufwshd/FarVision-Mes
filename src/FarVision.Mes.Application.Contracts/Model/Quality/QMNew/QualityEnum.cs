using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WebMES.Model.Quality
{

    public enum InspectionModeEnum
    {
        /// <summary>
        /// 常规检验
        /// </summary>
        Normal = 10,

        /// <summary>
        /// 复检
        /// </summary>
        Recheck = 20
    }

    public enum HandleResultEnum
    {
        /// <summary>
        /// 让步接收
        /// </summary>
        [Description("让步接收")]
        AOD = 10,

        /// <summary>
        /// 报废
        /// </summary>
        [Description("报废")]
        Scrap = 20,

        /// <summary>
        /// 返工/返修
        /// </summary>
        [Description("返工/返修")]
        Rework = 30,

        /// <summary>
        /// 验收退回
        /// </summary>
        [Description("验收退回")]
        SendBack = 40,

        /// <summary>
        /// 复检
        /// </summary>
        [Description("复检")]
        Recheck = 50,

        /// <summary>
        /// 入不良品仓
        /// </summary>
        [Description("入不良品仓")]
        EDW = 60,

        /// <summary>
        /// 强制入库
        /// </summary>
        [Description("强制入库")]
        CEW = 70
    }

    public enum GetTypeEnum
    {
        /// <summary>
        /// 无检验方案
        /// </summary>
        [Description("无检验方案")]
        None = -1,

        /// <summary>
        /// 检验方案
        /// </summary>
        [Description("检验方案")]
        InspectionScheme = 10,

        /// <summary>
        /// 产品检验方案
        /// </summary>
        [Description("产品检验方案")]
        ProductionInspectionScheme = 20
    }

    /// <summary>
    /// 送检单单据状态
    /// </summary>
    public enum BillStatusSendEnum
    {
        /// <summary>
        /// 待检验
        /// </summary>
        PendingInspection = 0,

        /// <summary>
        /// 检验中
        /// </summary>
        InInspection = 10,

        /// <summary>
        /// 已检验
        /// </summary>
        HasInspection = 20,

        /// <summary>
        /// 已判定
        /// </summary>
        HasDecide = 30,

        /// <summary>
        /// 已作废
        /// </summary>
        HasInvalid = 40,

        /// <summary>
        /// 已验收
        /// </summary>
        HasAcceptanceInspection = 50,

        /// <summary>
        /// 已完成
        /// </summary>
        Done = 60
    }

    /// <summary>
    /// 验收单单据状态
    /// </summary>
    public enum BillStatusAI
    {
        /// <summary>
        /// 准备
        /// </summary>
        Prepare = 10,

        /// <summary>
        /// 已判定
        /// </summary>
        HasDecide = 20,

        /// <summary>
        /// 已完成
        /// </summary>
        Done = 30,

    }

    public enum BillStatusEnum
    {
        /// <summary>
        /// 待执行
        /// </summary>
        Unexecuted = 0,

        /// <summary>
        /// 执行中
        /// </summary>
        Executing = 10,

        /// <summary>
        /// 完成
        /// </summary>
        Done = 20,

        /// <summary>
        /// 撤销
        /// </summary>
        Revocation = 30,

        /// <summary>
        /// 冲销
        /// </summary>
        WriteOff = 40
    }

    public enum SamplingRule
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,

        /// <summary>
        /// 放宽
        /// </summary>
        Broadening = 10,

        /// <summary>
        /// 免检
        /// </summary>
        EFI = 20,

        /// <summary>
        /// 加严
        /// </summary>
        Stricter = 30
    }

    public enum NewSamplingRule
    {
        I = 10,
        II = 20,
        III = 30,
        S1 = 40,
        S2 = 50,
        S3 = 60,
        S4 = 70,
        FixedValue = 80,
    }

    /// <summary>
    /// 方案类型
    /// </summary>
    public enum SchemesType
    {
        /// <summary>
        /// 试验记录
        /// </summary>
        TRYREC,

        /// <summary>
        /// 校准记录
        /// </summary>
        CALIB,

        /// <summary>
        /// 进货检验
        /// </summary>
        IQC,

        /// <summary>
        /// 出货检验
        /// </summary>
        OQC,

        /// <summary>
        /// 库存检验
        /// </summary>
        IVQC,

        /// <summary>
        /// 工序检验
        /// </summary>
        IPQC,

        /// <summary>
        /// 首检检验
        /// </summary>
        FQC,

        /// <summary>
        /// 巡检检验
        /// </summary>
        PQC,

        /// <summary>
        /// 末件检验
        /// </summary>
        EQC,

        /// <summary>
        /// SPC
        /// </summary>
        SPC
    }

    /// <summary>
    /// 转单来源
    /// </summary>
    public enum TransferFormSource
    {
        /// <summary>
        /// 送检单转单
        /// </summary>
        SendInspection,

        /// <summary>
        /// 验收单转单
        /// </summary>
        AcceptanceInspection
    }

    public enum TransferFormBillType
    {
        /// <summary>
        /// 退货转移库
        /// </summary>
        TransferFormReturnProduct,

        /// <summary>
        /// 合格转移库
        /// </summary>
        TranFormBuy,

        /// <summary>
        /// 报废转出库
        /// </summary>
        WasteOut,

        /// <summary>
        /// 退货转出库
        /// </summary>
        PurchaseReturn
    }

    public enum TransferFormBillStatus
    {
        /// <summary>
        /// 准备
        /// </summary>
        Prepare = 10,

        /// <summary>
        /// 完成
        /// </summary>
        Done = 40,
    }

    public enum BarcodeHandleResult
    { 
        /// <summary>
        /// 退货
        /// </summary>
        Return,

        /// <summary>
        /// 合格
        /// </summary>
        Qualified,

        /// <summary>
        /// 让步接收
        /// </summary>
        AOD,

        /// <summary>
        /// 报废
        /// </summary>
        Scrap,

        /// <summary>
        /// 限制使用
        /// </summary>
        RestrictedForUse
    }
}
