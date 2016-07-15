using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Storage
{
   /// <summary>
    /// Sku信息
   /// </summary>
    public class StorageSkuDto
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家Sku
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// 出口易Sku
        /// </summary>
        public string Ck1Sku { get; set; }

        /// <summary>
        /// 库存编码
        /// </summary>
        public string StorageNo { get; set; }

        /// <summary>
        /// 重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 长(cm)
        /// </summary>
        public decimal Length { get; set; }

        /// <summary>
        /// 宽(cm)
        /// </summary>
        /// <example>10</example>
        public decimal Width { get; set; }

        /// <summary>
        /// 高(cm)
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// 申报名称
        /// </summary>
        public string DeclareName { get; set; }

        /// <summary>
        /// 申报价值(USD)
        /// </summary>
        public decimal DeclareValue { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public ProductFlag ProductFlag { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
    }
}
