using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Inbound
{
    public class GetInboundOrderLabelRequest
    {
        /// <summary>
        /// 打印格式
        /// </summary>
        public PrintFormat PrintFormat { get; set; }

        /// <summary>
        /// 打印内容
        /// </summary>
        public InboundPrintContent PrintContent { get; set; }

        /// <summary>
        /// 入库单Id
        /// </summary>
        public string ShipmentId { get; set; }
    }
}
