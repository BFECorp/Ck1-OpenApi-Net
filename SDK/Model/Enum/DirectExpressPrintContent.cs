namespace CK1.OpenPlatform.SDK.Model.Enum
{
    /// <summary>
    /// 直发标签打印内容
    /// </summary>
    public enum DirectExpressPrintContent
    {
        /// <summary>
        /// 只打印地址
        /// </summary>
        Address,
        /// <summary>
        /// 同一张打印地址与报关单
        /// </summary>
        AddressCostoms,
        /// <summary>
        /// 分开打印地址与报关单
        /// </summary>
        AddressCostomsSplit,
        /// <summary>
        /// 打印地址与配货清单（只支持ClassicLabel）
        /// </summary>
        AddressRemark,
        /// <summary>
        /// 打印地址、报关单与配货清单（只支持ClassicLabel）
        /// </summary>
        AddressCustomsRemarkSplit
    }
}
