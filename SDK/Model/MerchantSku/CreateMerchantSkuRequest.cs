
namespace CK1.OpenPlatform.SDK.Model.MerchantSku
{
    using CK1.OpenPlatform.SDK.Model.Enum;

    /// <summary>
    /// 表示添加商家SKU的请求
    /// </summary>
    public class CreateMerchantSkuRequest
    {
        /// <summary>
        /// 商家ID
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// 自定义库存编码
        /// </summary>
        public string CustomStorageNo { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        public string ProductDescription { get; set; }

        /// <summary>
        /// 重量(g)
        /// </summary>
        /// <example>
        /// 600
        /// </example>
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
        /// 库存警报
        /// </summary>
        public int ProductAmountWarn { get; set; }

        /// <summary>
        /// 产品品类
        /// </summary>
        public string ProductCategory { get; set; }

        /// <summary>
        /// 产品备注
        /// </summary>
        public string ProductRemark { get; set; }
    }
}
