namespace CK1.OpenPlatform.SDK.Model.Enum
{
    /// <summary>
    /// 直发标签Custom区域的内容选项
    /// </summary>
    public enum DirectExpressCustomPrintOption
    {
        /// <summary>
        /// 指定包含包裹号(RefNo)
        /// </summary>
        RefNo,
        /// <summary>
        /// 指定包含Sku信息
        /// </summary>
        Sku,
        /// <summary>
        /// 指定包含英文品名信息
        /// </summary>
        CustomsTitleEn,
        /// <summary>
        /// 指定包含中文品名信息
        /// </summary>
        CustomsTitleCn,
        /// <summary>
        /// 指定包含自定义信息(Custom)
        /// </summary>
        Custom,
        /// <summary>
        /// 指定包含备注信息(Remark)
        /// </summary>
        Remark
    }
}
