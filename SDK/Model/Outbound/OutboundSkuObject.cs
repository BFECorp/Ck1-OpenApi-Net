namespace CK1.OpenPlatform.SDK.Model.Outbound
{
    /// <summary>
    /// SKU列表项
    /// </summary>
    public class OutboundSkuObject
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
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        public decimal Price { get; set; }
    }
}
