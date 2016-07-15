namespace CK1.OpenPlatform.SDK.Model.Rma
{
    /// <summary>
    /// 退货仓库
    /// </summary>
    public class RmaWarehouse
    {
        /// <summary>
        /// 仓库代码
        /// </summary>
        public System.String Code { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// 所属国家
        /// </summary>
        public System.String Country { get; set; }
        
        /// <summary>
        /// 地址
        /// </summary>
        public System.String Address { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enabled { get; set; }
    }
}
