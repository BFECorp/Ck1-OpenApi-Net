using System.Collections.Generic;
using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Inbound
{
    /// <summary>
    /// 表示获取入库单状态的响应
    /// </summary>
    public class GetInboundOrderStatusResponse 
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家入库单Id
        /// </summary>
        public string ShipmentId { get; set; }

        /// <summary>
        /// 状态:Open 处理中Closed 已完成
        /// </summary>
        public ShipmentStatus Status { get; set; }

        /// <summary>
        /// SKU列表
        /// </summary>
        public List<SkuObject> Skus { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public string LastUpdated { get; set; }
    }

    /// <summary>
    /// SKU列表项
    /// </summary>
    public class SkuObject
    {
        /// <summary>
        /// 商家SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 单个重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 实际数量
        /// </summary>
        public int ArrivalQuantity { get; set; }

        /// <summary>
        /// 轨迹信息列表
        /// </summary>
        public List<TrackingObject> Trackings { get; set; }
    }

    /// <summary>
    /// 轨迹信息
    /// </summary>
    public class TrackingObject
    {
        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 发生时间
        /// </summary>
        public string TrackingTime { get; set; }
    }
}
