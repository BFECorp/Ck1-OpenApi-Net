namespace CK1.OpenPlatform.SDK.Model
{
    /// <summary>
    /// 未发货或创建失败原因
    /// </summary>
    public class UnShippedReason
    {
        /// <summary>
        /// 代码
        /// </summary>
        public string ReasonCode { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string ReasonText { get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        public string ExtendMessage { get; set; }
    }
}
