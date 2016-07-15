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
        /// 所属商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 出库包裹ID
        /// </summary>
        public string PackageId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public ShippedStatus Status { get; set; }

        /// <summary>
        /// 未发货原因 
        /// </summary>
        public UnShippedReason UnShippedReason { get; set; }

        /// <summary>
        /// 跟踪号
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 承运商
        /// </summary>
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
