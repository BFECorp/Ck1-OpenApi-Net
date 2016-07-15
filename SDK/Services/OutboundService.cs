using System.Collections.Generic;

using CK1.OpenPlatform.SDK.HttpHelper;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Outbound;
using RestSharp;

namespace CK1.OpenPlatform.SDK.Services
{
    /// <summary>
    /// 二程出库
    /// </summary>
    public class OutboundService:OpenApiServiceBase
    {
        public OutboundService(string accessToken) : base(accessToken) { }

        /// <summary>
        /// 创建二程出库单
        /// </summary>
        public ResponseModel<object> CreateOutboundOrder(CreateOutboundOrderRequest request)
        {
            var resource = "outboundOrders";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.Execute(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 获取出库单状态
        /// </summary>
        /// <param name="packageId"> 包裹ID</param>
        public ResponseModel<GetOutboundOrderStatusResponse> GetOutboundOrderStatus(string packageId)
        {
            var resource = "outboundOrders/{packageId}/status";
            var urlSegments = new Dictionary<string, string>
            {
                {"packageId", packageId}
            };
            var requests = this._client.BuildRequest(Method.GET, resource,  urlSegments, null);
            var response = this._client.GenericExecute<GetOutboundOrderStatusResponse>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 取消二程出库单
        /// </summary>
        /// <param name="packageId"> 包裹ID</param>
        public ResponseModel<object> CancelOutboundOrder(string packageId)
        {
            var resource = "outboundOrders/{packageId}/cancelState";
            var urlSegments = new Dictionary<string, string>
            {
                {"packageId", packageId}
            };
            var requests = this._client.BuildRequest(Method.PUT, resource,urlSegments, null);
            var response = this._client.Execute(requests);
            return this.GetResult(response);
        }
    }
}
