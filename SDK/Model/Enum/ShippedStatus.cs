namespace CK1.OpenPlatform.SDK.Model.Enum
{
    /// <summary>
    /// 二程出库状态
    /// </summary>
    public enum ShippedStatus
    {
        /// <summary>
        /// 创建中
        /// </summary>
        Creating,
        /// <summary>
        /// 待处理
        /// </summary>
        Pending,
        /// <summary>
        /// 处理中
        /// </summary>
        Processing,
        /// <summary>
        /// 已发货
        /// </summary>
        Shipped,
        /// <summary>
        /// 未发货
        /// </summary>
        UnShipped,
        /// <summary>
        /// 已取消
        /// </summary>
        Canceled 
    }
}
