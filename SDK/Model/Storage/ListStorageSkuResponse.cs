using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Model.Storage
{
    /// <summary>
    /// 仓储Sku列表
    /// </summary>
    public class ListStorageSkuResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Sku列表
        /// </summary>
        public List<StorageSkuDto> Skus { get; set; }
    }
}
