using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Model.Pricing
{
    /// <summary>
    /// 表示计费结果
    /// </summary>
    public class PricingResponse
    {
        /// <summary>
        /// 服务代码
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 是否计费成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 计费信息(不成功原因)
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 费用信息
        /// </summary>
        public ChargeInfo ChargeInfo { get; set; }
    }
    /// <summary>
    /// 费用信息
    /// </summary>
    public class ChargeInfo
    {
        /// <summary>
        /// 总费用
        /// </summary>
        public List<ChargeSummary> Summary { get; set; }
        /// <summary>
        /// 费用明细
        /// </summary>
        public List<ChargeDetail> Detail { get; set; }
    }
    /// <summary>
    /// 费用明细
    /// </summary>
    public class ChargeDetail
    {
        /// <summary>
        /// 货币类型
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 费用
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 费用描述
        /// </summary>
        public string Remark { get; set; }
    }
    /// <summary>
    /// 总费用
    /// </summary>
    public class ChargeSummary
    {
        /// <summary>
        /// 货币类型
        /// </summary>
        public string Currency { get; set; }
        /// <summary>
        /// 费用
        /// </summary>
        public decimal Amount { get; set; }
    }
}
