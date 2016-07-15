using System;
using CK1.OpenPlatform.SDK.Model.Enum;

namespace CK1.OpenPlatform.SDK.Model.Rma
{
    /// <summary>
    /// 退货商品列表项
    /// </summary>
    public class RmaProductInfo
    {
        /// <summary>
        /// 商品号
        /// </summary>
        public string ProductNo { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; set; }

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
        /// 重量(g)
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// 申报价值(USD)
        /// </summary>
        public decimal DeclareValue { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 处理方式
        /// </summary>
        public RmaHandleType HandleType { get; set; }

        /// <summary>
        /// 产品品类
        /// </summary>
        public string ProductCategory { get; set; }
    }
}
