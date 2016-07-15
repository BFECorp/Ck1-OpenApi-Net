namespace CK1.OpenPlatform.SDK.Model.DirectExpress
{
    using System.Collections.Generic;

    using CK1.OpenPlatform.SDK.Model.Enum;

    /// <summary>
    /// 表示获取直发包裹标签请求
    /// </summary>
    public class GetDirectExpressOrdersLabelRequest
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 直发包裹Id列表
        /// </summary>
        public List<string> PackageIds { get; set; }

        /// <summary>
        /// 打印格式
        /// </summary>
        public PrintFormat PrintFormat { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        public DirectExpressPrintContent PrintContent { get; set; }

        /// <summary>
        /// Custom区域的内容选项
        /// </summary>
        public List<DirectExpressCustomPrintOption> CustomPrintOptions { get; set; }
    }
}
