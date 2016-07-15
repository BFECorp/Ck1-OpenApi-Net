namespace CK1.OpenPlatform.SDK.Services
{
    using System.Collections.Generic;

    using CK1.OpenPlatform.SDK.HttpHelper;
    using CK1.OpenPlatform.SDK.Model;
    using CK1.OpenPlatform.SDK.Model.DirectExpress;

    using RestSharp;

    /// <summary>
    /// 直发服务
    /// </summary>
    public class DirectExpressService:OpenApiServiceBase
    {
        public DirectExpressService(string accessToken) : base(accessToken) { }
        /// <summary>
        /// 创建直发订单
        /// </summary>
        public ResponseModel<object> CreateDirectExpressOrder(CreateDirectExpressOrderRequest request)
        {
            var resource = "directExpressOrders";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.Execute(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 获取直发包裹标签
        /// </summary>
        public ResponseModel<LabelObject> GetDirectExpressOrderLabel(GetDirectExpressOrdersLabelRequest request)
        {
            var resource = "directExpressOrders/label";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.GenericExecute<LabelObject>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 获取中国直发订单状态
        /// </summary>
        /// <param name="packageId">包裹Id</param>
        public ResponseModel<GetDirectExpressStatusResponse> GetDirectExpressOrderStatus(string packageId)
        {
            var resource = "directExpressOrders/{packageId}/status";
            var urlSegments = new Dictionary<string, string>
            {
                {"packageId", packageId}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, urlSegments, null);
            var response = this._client.GenericExecute<GetDirectExpressStatusResponse>(requests);
            return this.GetResult(response);
        }
    }
}
