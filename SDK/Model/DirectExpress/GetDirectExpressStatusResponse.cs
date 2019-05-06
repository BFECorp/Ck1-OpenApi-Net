namespace CK1.OpenPlatform.SDK.Model.DirectExpress
{
    using CK1.OpenPlatform.SDK.Model.Enum;
    using System.Collections.Generic;

    /// <summary>
    /// 表示获取出库单状态的响应
    /// </summary>
    public class GetDirectExpressStatusResponse
    {
        /// <summary>
        /// 出库包裹ID
        /// </summary>
        /// <example>
        /// SMT23015236489
        /// </example>
        public string PackageId { get; set; }

        /// <summary>
        /// 处理号
        /// </summary>
        /// <example>
        /// EUU20160808TST00001
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
        public DirectExpressOrderStatus? HandleStatus { get; set; }

        /// <summary>
        /// 跟踪号
        /// </summary>
        /// <example>
        /// T024963157
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
        /// 初始包裹重量(g)
        /// </summary>
        /// <example>
        /// 600
        /// </example>
        public int WeightInit { get; set; }

        /// <summary>
        /// 初始包装尺寸(cm)
        /// </summary>
        public Packing PackingInit { get; set; }

        /// <summary>
        /// 核实包裹重量(g)
        /// </summary>
        /// <example>
        /// 600
        /// </example>
        public int Weight { get; set; }

        /// <summary>
        /// 核实包装尺寸(cm)
        /// </summary>
        public Packing Packing { get; set; }

        /// <summary>
        /// 计费重量(g)
        /// </summary>
        /// <example>
        /// 600
        /// </example>
        public int ChargedWeight { get; set; }

        /// <summary>
        /// 创建失败原因 
        /// </summary>
        public UnShippedReason CreateFailedReason { get; set; }

        /// <summary>
        /// 费用列表,已完成出库才会返回费用信息
        /// </summary>
        public List<ShippingCost> ShippingCosts { get; set; }

        /// <summary>
        /// 是否产生偏远地区费用
        /// </summary>
        public bool HasRemoteFee { get; set; }

    }

}
