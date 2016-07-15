using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Rma
{
    /// <summary>
    /// 退货信息
    /// </summary>
    public class RmaInfoDto
    {
        /// <summary>
        /// 退货订单Id
        /// </summary>
        public string RmaOrderId { get; set; }
        /// <summary>
        /// 仓库Id
        /// </summary>
        public string RmaWarehouseId { get; set; }
        /// <summary>
        /// 商品号
        /// </summary>
        public string ProductNo { get; set; }
        /// <summary>
        /// 预收数量
        /// </summary>
        public int QuantityInit { get; set; }
        /// <summary>
        /// 实收数量
        /// </summary>
        public int QuantityHandle { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public string HandleTime { get; set; }
        /// <summary>
        /// 处理方式
        /// </summary>
        public RmaHandleType HandleType { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public RmaOrderStatus Status { get; set; }
    }
}
