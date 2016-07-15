
namespace CK1.OpenPlatform.SDK.Model
{
    /// <summary>
    /// 收货地址，联系人
    /// </summary>
    public class ShipToAddress
    {
        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 省/州
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 街道1
        /// </summary>
        /// <example>
        public string Street1 { get; set; }

        /// <summary>
        /// 街道2
        /// </summary>   
        public string Street2 { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
    }
}
