using System.Collections.Generic;
using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Outbound
{
    /// <summary>
    /// 表示获取出库单状态的响应
    /// </summary>
    public class GetOutboundOrderStatusResponse
    {
        /// <summary>
        /// 出库包裹ID
        /// </summary>
        /// <example>
        /// MN006T0005
        /// </example>
        public string PackageId { get; set; }

        /// <summary>
        ///CK1处理号
        /// </summary>
        /// <example>
        /// MN20160808TST0001
        /// </example>
        public string Ck1PackageId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        /// <example>
        /// Creating
        /// </example>
        public CreateStatus Status { get; set; }

        /// <summary>
        /// 处理状态
        /// </summary>
        /// <example>
        /// Submitted
        /// </example>
        public OutboundOrderStatus? HandleStatus { get; set; }

        /// <summary>
        /// 未发货原因 
        /// </summary>
        public UnShippedReason UnShippedReason { get; set; }

        /// <summary>
        /// 跟踪号
        /// </summary>
        /// <example>
        /// ac7cdd60d5e24
        /// </example>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 承运商
        /// </summary>
        /// <example>
        /// DHL
        /// </example>
        public string ShippingProvider { get; set; }

        /// <summary>
        /// 费用列表
        /// </summary>
        public List<ShippingCost> ShippingCosts { get; set; }

        /// <summary>
        /// 包裹重量(g) 
        /// </summary>
        /// <example>600</example>
        public double Weight { get; set; }

        /// <summary>
        /// 是否有偏远地区费用
        /// </summary>
        /// <example>false</example>
        public bool HasRemoteFee { get; set; }
    }

    /// <summary>
    /// 费用列表
    /// </summary>
    public class ShippingCost
    {
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Money { get; set; }

        /// <summary>
        /// 货币
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }

}
