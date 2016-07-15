namespace CK1.OpenPlatform.SDK.Model.Enum
{
    /// <summary>
    /// 直发订单状态
    /// </summary>
    public enum ExpressStatus
    {
        /// <summary>
        /// 创建中
        /// </summary>
        Creating,
        /// <summary>
        /// 创建成功
        /// </summary>
        Created,
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
        CreateFailed,
        /// <summary>
        /// 已取消
        /// </summary>
        Canceled 
    }
}
