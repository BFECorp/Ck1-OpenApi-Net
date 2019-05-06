namespace CK1.OpenPlatform.SDK.Model
{
    using System.Net;

    using CK1.OpenPlatform.SDK.Model.ErrorModel;
    /// <summary>
    /// 返回结果
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseModel<T>
    {
        /// <summary>
        /// 失败信息
        /// </summary>
        public Ck1ErrorModel Error { get; set; }
        /// <summary>
        /// 返回 HTTP Status Code
        /// </summary>
        public HttpStatusCode StatusCode { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 结果数据
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// 返回值
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
