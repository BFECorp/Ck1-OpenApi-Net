
namespace CK1.OpenPlatform.SDK.Model.DirectExpress
{
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
        /// 单件重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 单件申报价值(USD)
        /// </summary>
        public decimal DeclareValue { get; set; }

        /// <summary>
        /// 英文申报名称
        /// </summary>
        public string DeclareNameEn { get; set; }

        /// <summary>
        /// 中文申报名称
        /// </summary>
        public string DeclareNameCn { get; set; }

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
