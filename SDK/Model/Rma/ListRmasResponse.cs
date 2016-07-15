using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Model.Rma
{
    /// <summary>
    /// 退货信息列表
    /// </summary>
    public class ListRmasResponse
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
        /// 退货信息列表
        /// </summary>
        public List<RmaInfoDto> Rmas { get; set; }
    }
}
