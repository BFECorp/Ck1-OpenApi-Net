namespace CK1.OpenPlatform.SDK.Model.Rma
{
    /// <summary>
    /// 表示查询退货信息列表的请求
    /// </summary>
    public class ListRmasRequest
    {
        /// <summary>
        /// 仓库Id
        /// </summary>
        public string RmaWarehouseId { get; set; }

        /// <summary>
        /// 起始处理时间(UTC)
        /// </summary>
        public string HandleTimeStart { get; set; }

        /// <summary>
        /// 结束处理时间(UTC)
        /// </summary>
        public string HandleTimeEnd { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public RmaOrderStatus? Status { get; set; }

        /// <summary>
        /// 起始创建时间(UTC)
        /// </summary>
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// 结束创建时间(UTC)
        /// </summary>
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public int PageSize { get; set; }
    }
}
