using System.Collections.Generic;
using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Rma
{
    /// <summary>
    /// 表示创建退货单请求
    /// </summary>
    public class GetRmaOrderLabelRequest
    {
        /// <summary>
        /// 退货订单Id
        /// </summary>
        public string RmaOrderId { get; set; }

        /// <summary>
        /// 出口易仓库代码
        /// </summary>
        public string RmaWarehouseId { get; set; }

        /// <summary>
        /// 退货商品列表
        /// </summary>
        public List<RmaProductInfo> Products { get; set; }

        /// <summary>
        /// 打印格式，目前只支持ClassicLabel
        /// </summary>
        public PrintFormat PrintFormat { get; set; }

        /// <summary>
        /// 退件订单物流服务商
        /// </summary>
        public string RmaShippingProvider { get; set; }

        /// <summary>
        /// 退件订单挂号
        /// </summary>
        public string RmaTrackingNumber { get; set; }
    }
}
