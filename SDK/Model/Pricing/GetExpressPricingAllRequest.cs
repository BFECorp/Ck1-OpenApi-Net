namespace CK1.OpenPlatform.SDK.Model.Pricing
{
    /// <summary>
    /// 表示取得某个直发包裹信息的可用服务列表及所需运费请求
    /// </summary>
    public class GetExpressPricingAllRequest
    {
        /// <summary>
        /// 出口易处理点代码
        /// </summary>
        public string LocationId { get; set; }

        /// <summary>
        /// 包裹重量(g)
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
        /// 发往国家(支持标准二字简称)
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 发往地区邮编
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 收件人详细地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 发往地区省/州
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 发往地区城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 包含计费失败的结果默认不包含
        /// </summary>
        public bool? IncludeUnsuccessful { get; set; }
    }
}
