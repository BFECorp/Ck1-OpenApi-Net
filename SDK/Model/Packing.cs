namespace CK1.OpenPlatform.SDK.Model
{
    /// <summary>
    /// 包装尺寸
    /// </summary>
    public class Packing
    {
        /// <summary>
        /// 长(cm)
        /// </summary>
        /// <example>
        /// 20
        /// </example>
        public decimal Length { get; set; }
        /// <summary>
        /// 宽(cm)
        /// </summary>
        /// <example>
        /// 10
        /// </example>
        public decimal Width { get; set; }
        /// <summary>
        /// 高(cm)
        /// </summary>
        /// <example>
        /// 25
        /// </example>
        public decimal Height { get; set; }
    }
}
