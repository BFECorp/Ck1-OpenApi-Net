namespace CK1.OpenPlatform.SDK.Model.Inbound
{
    using System.Collections.Generic;

    /// <summary>
    /// 表示添加入库单的请求
    /// </summary>
    public class CreateInboundOrderRequest
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
        /// 处理点;如不填则使用商家默认处理点
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// 发货方式
        /// </summary>
        public string ShippingType { get; set; }

        /// <summary>
        /// 箱子列表
        /// </summary>
        public List<ContainerInfo> Containers { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
       
    }

    /// <summary>
    /// 箱子信息
    /// </summary>
    public class ContainerInfo
    {
        /// <summary>
        /// 自定义箱号
        /// </summary>
        public string CustomContainerNo { get; set; }

        /// <summary>
        /// 重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 长（cm）
        /// </summary>
        public decimal Length { get; set; }

        /// <summary>
        /// 宽（cm）
        /// </summary>
        public decimal Width { get; set; }

        /// <summary>
        /// 高（cm）
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// SKU列表
        /// </summary>
        public List<InboundSkuObject> Skus { get; set; }
    }

    /// <summary>
    /// SKU列表项
    /// </summary>
    public class InboundSkuObject
    {
        /// <summary>
        /// 商家SKU
        /// </summary>
        public string Sku { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }
    }
}
