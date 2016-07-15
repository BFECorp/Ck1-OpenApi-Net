namespace CK1.OpenPlatform.SDK.Model.MerchantSku
{
    using CK1.OpenPlatform.SDK.Model.Enum;
    /// <summary>
    /// 表示获取Sku库存编码标签请求
    /// </summary>
    public class GetSkuLabelRequest
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 仓库代号
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// sku名称
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 打印格式
        /// </summary>
        public PrintFormat PrintFormat { get; set; }
    }
}
