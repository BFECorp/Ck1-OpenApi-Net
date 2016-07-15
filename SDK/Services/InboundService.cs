using System.Collections.Generic;

namespace CK1.OpenPlatform.SDK.Services
{
    using CK1.OpenPlatform.SDK.HttpHelper;
    using CK1.OpenPlatform.SDK.Model;
    using CK1.OpenPlatform.SDK.Model.Inbound;

    using RestSharp;
    /// <summary>
    /// 头程入库
    /// </summary>
    public class InboundService:OpenApiServiceBase
    {
        public InboundService(string accessToken) : base(accessToken) { }
        /// <summary>
        /// 创建入库单
        /// </summary>
        public ResponseModel<object> CreateInboundOrders(CreateInboundOrderRequest request)
        {
            var resource = "inboundOrders";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.Execute(requests);
            return this.GetResult(response);
        }
        /// <summary>
        /// 入库单状态
        /// </summary>
        /// <param name="shipmentId">入库单Id</param>
        public ResponseModel<GetInboundOrderStatusResponse> GetInboundOrderStatus(string shipmentId)
        {
            var resource = "inboundOrders/{shipmentId}/status";
            var urlSegments = new Dictionary<string, string>
            {
                {"shipmentId", shipmentId}
            };
            var requests = this._client.BuildRequest(Method.GET, resource,urlSegments, null);
            var response = this._client.GenericExecute<GetInboundOrderStatusResponse>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 获取入库装箱单标签
        /// </summary>
        /// <param name="request"></param>
        public ResponseModel<LabelObject> GetInboundOrderLabel(GetInboundOrderLabelRequest request)
        {
            var resource = "inboundOrders/{shipmentId}/label";
            var urlSegments = new Dictionary<string, string>
            {
                {"shipmentId", request.ShipmentId}
            };
            var parameters = new Dictionary<string, string>
            {
                {"PrintFormat", request.PrintFormat.ToString()},
                {"PrintContent", request.PrintContent.ToString()}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, urlSegments, parameters);
            var response = this._client.GenericExecute<LabelObject>(requests);
            return this.GetResult(response);
        }

    }
}
