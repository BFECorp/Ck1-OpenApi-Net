using CK1.OpenPlatform.SDK.Model.Enum;
using System;
using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Model.Outbound
{
    /// <summary>
    /// 包裹信息
    /// </summary>
    public class Package
    {
        /// <summary>
        /// 出库包裹Id
        /// </summary>
        public string PackageId { get; set; }

        /// <summary>
        /// 发货服务代码
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 收货地址，联系人
        /// </summary>
        public ShipToAddress ShipToAddress { get; set; }

        /// <summary>
        /// SKU列表
        /// </summary>
        public List<OutboundSkuObject> Skus { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public decimal SellPrice { get; set; }

        /// <summary>
        /// 售价货币
        /// </summary>
        public Currency SellPriceCurrency { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 销售平台
        /// </summary>
        public SalesPlatform SalesPlatform { get; set; }

    }
}
