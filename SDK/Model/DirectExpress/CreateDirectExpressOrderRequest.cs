
namespace CK1.OpenPlatform.SDK.Model.DirectExpress
{
    /// <summary>
    /// 表示添加二程出库单的请求
    /// </summary>
    public class CreateDirectExpressOrderRequest
    {
        /// <summary>
        /// 所属商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 处理点
        /// 如不填则使用商家默认
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// 出库包裹信息
        /// </summary>
        public Package Package { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }

}
