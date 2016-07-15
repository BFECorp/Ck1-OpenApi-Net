namespace CK1.OpenPlatform.SDK.Model.DirectExpress
{
    using CK1.OpenPlatform.SDK.Model.Enum;

    /// <summary>
    /// 表示获取出库单状态的响应
    /// </summary>
    public class GetDirectExpressStatusResponse  
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
        public ExpressStatus Status { get; set; }

        /// <summary>
        /// 跟踪号
        /// </summary>
        public string TrackingNumber { get; set; }

        /// <summary>
        /// 承运商
        /// </summary>
        public string ShippingProvider { get; set; }

        /// <summary>
        /// 初始包裹重量(g)
        /// </summary>
        public int WeightInit { get; set; }

        /// <summary>
        /// 初始包装尺寸(cm)
        /// </summary>
        public Packing PackingInit { get; set; }

        /// <summary>
        /// 核实包裹重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 核实包装尺寸(cm)
        /// </summary>
        public Packing Packing { get; set; }

        /// <summary>
        /// 计费重量(g)
        /// </summary>
        public int ChargedWeight { get; set; }

        /// <summary>
        /// 创建失败原因
        /// </summary>
        public UnShippedReason CreateFailedReason { get; set; }

    }

}
