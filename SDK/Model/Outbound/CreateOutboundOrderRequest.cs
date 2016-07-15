namespace CK1.OpenPlatform.SDK.Model.Outbound
{
    /// <summary>
    /// 表示添加二程出库单的请求
    /// </summary>
    public class CreateOutboundOrderRequest
    {
        /// <summary>
        /// 所属商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// 出库包裹信息
        /// </summary>
        public Package Package { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }

}
