using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Storage
{
    /// <summary>
    /// 表示查询某个仓库的仓储Sku列表请求
    /// </summary>
    public class ListStorageSkuRequest
    {
        /// <summary>
        /// 仓库Id
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }
        
        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; }
        
        /// <summary>
        /// 排序
        /// </summary>
        public StorageSkuSortingType Sorting { get; set; }
    }
}
