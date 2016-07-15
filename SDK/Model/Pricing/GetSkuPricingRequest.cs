using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Model.Pricing
{
    /// <summary>
    /// 表示计算多个SKU产品在某种发货方式下的运费请求
    /// </summary>
    public class GetSkuPricingRequest
    {
        /// <summary>
        /// 商家Id
        /// </summary>
        public string MerchantId { get; set; }

        /// <summary>
        /// 发货服务代码
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// sku名称:数量
        /// </summary>
        public List<SkuInfo> Skus { get; set; }

        /// <summary>
        /// 仓库代号
        /// </summary>
        public string WarehouseId { get; set; }

        /// <summary>
        /// 发往国家(支持标准二字简称)
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 发往地区邮编(当地派送必须)
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 收件人详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 发往地区城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 发往地区省/州
        /// </summary>
        public string Province { get; set; }

    }
}
