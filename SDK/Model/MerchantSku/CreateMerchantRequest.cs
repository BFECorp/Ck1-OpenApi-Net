namespace CK1.OpenPlatform.SDK.Model.MerchantSku
{
    /// <summary>
    /// 表示添加商家的请求
    /// </summary>
    public class CreateMerchantRequest
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        public string MerchantName { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 联系邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 默认处理点
        /// </summary>
        public string Location { get; set; }
    }
}
