namespace CK1.OpenPlatform.SDK.Model.ErrorModel
{
    using System.Collections.Generic;
    /// <summary>
    /// 失败信息
    /// </summary>
    public class Ck1ErrorModel
    {
        /// <summary>
        /// 详细错误信息列表
        /// </summary>
        public List<Ck1Error> Errors { get; set; }
        /// <summary>
        /// 唯一编号
        /// </summary>
        public string TicketId { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public string DateTime { get; set; }
        /// <summary>
        /// 请求的Url
        /// </summary>
        public string RequestUri { get; set; }
    }
    /// <summary>
    /// 详细错误信息
    /// </summary>
    public class Ck1Error
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string Message { get; set; }
    }
}
