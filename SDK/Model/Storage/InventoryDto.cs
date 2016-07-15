namespace CK1.OpenPlatform.SDK.Model.Storage
{
    /// <summary>
    /// 表示查询某个Sku在某个仓库的库存情况
    /// </summary>
    public class InventoryDto
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// 商家SKU
        /// </summary>
        public string Sku { get; set; }

        /// <summary>
        /// 库存编码
        /// </summary>
        public string StorageNo { get; set; }

        /// <summary>
        /// 实际库存数
        /// </summary>
        public int TotalStockQty { get; set; }

        /// <summary>
        /// 可用库存数
        /// </summary>
        public int AvailStockQty { get; set; }
        
    }
}
