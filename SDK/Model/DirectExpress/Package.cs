namespace CK1.OpenPlatform.SDK.Model.DirectExpress
{
    using System.Collections.Generic;

    using CK1.OpenPlatform.SDK.Model.Enum;

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
        /// 重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 长(cm)
        /// </summary>
        public decimal Length { get; set; }
        /// <summary>
        /// 宽(cm)
        /// </summary>
        public decimal Width { get; set; }
        /// <summary>
        /// 高(cm)
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// SKU列表
        /// </summary>
        public List<SkuObject> Skus { get; set; }

        /// <summary>
        /// 售价
        /// </summary>
        public decimal SellPrice { get; set; }

        /// <summary>
        /// 售价货币
        /// </summary>
        public Currency SellPriceCurrency { get; set; }

        /// <summary>
        /// 销售平台
        /// </summary>
        public SalesPlatform SalesPlatform { get; set; }

        /// <summary>
        /// 导入的跟踪号，如果服务允许导入跟踪号时有效
        /// </summary>
        public string ImportTrackingNumber { get; set; }

        /// <summary>
        /// 客户自定义，最长200个字符，可以用于打印在地址标签Custom区域
        /// </summary>
        public string Custom { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

    }
}
