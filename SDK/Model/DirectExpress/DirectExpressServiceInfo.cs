namespace CK1.OpenPlatform.SDK.Model.DirectExpress
{
    /// <summary>
    /// 直发服务
    /// </summary>
    public class DirectExpressServiceInfo
    {
        /// <summary>
        /// 出口易发货服务代码
        /// </summary>
        public string ServiceCode { get; set; }

        /// <summary>
        /// 发货服务名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 是否挂号
        /// </summary>
        public bool IsTracking { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool InService { get; set; }

        /// <summary>
        /// 是否可导入trackingNo
        /// </summary>
        public bool CanImportTracking { get; set; }
    }
}
