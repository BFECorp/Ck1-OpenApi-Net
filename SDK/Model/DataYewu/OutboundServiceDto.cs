namespace CK1.OpenPlatform.SDK.Model.DataYewu
{
    /// <summary>
    /// 表示查询某仓库二程发货服务列表的响应
    /// </summary>
    public class OutboundServiceDto
    {
        /// <summary>
        /// 出口易发货服务代码
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 发货服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 是否挂号
        /// </summary>
        public bool IsTracking { get; set; }
    }
}
