using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Model.Storage
{
    /// <summary>
    /// 表示查询Sku在某个仓库的库存情况的请求
    /// </summary>
    public class InventoriesRequest
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家SKU
        /// </summary>
        public List<string> Skus { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public string WarehouseId { get; set; }
    }

    /// <summary>
    /// 表示查询Sku在某个仓库的库存情况的请求
    /// </summary>
    public class GetInventoriesRequest
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家SKU,sku间用英文逗号隔开
        /// </summary>
        public string Skus { get; set; }

        /// <summary>
        /// 仓库Id
        /// </summary>
        public string WarehouseId { get; set; }
    }
}
