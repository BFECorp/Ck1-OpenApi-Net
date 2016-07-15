namespace CK1.OpenPlatform.SDK.Model.DataYewu
{
    /// <summary>
    /// 表示查询海外仓库列表的响应
    /// </summary>
    public class WarehouseDto
    {
        /// <summary>
        /// 仓库代码
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string WarehouseName { get; set; }

        /// <summary>
        /// 所属国家
        /// </summary>
        public string Country { get; set; }
    }
}
