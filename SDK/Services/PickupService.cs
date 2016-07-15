using CK1.OpenPlatform.SDK.HttpHelper;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Pickup;
using System.Collections.Generic;
using RestSharp;

namespace CK1.OpenPlatform.SDK.Services
{
    /// <summary>
    /// 收货服务
    /// </summary>
    public class PickupService:OpenApiServiceBase
    {
        public PickupService(string accessToken) : base(accessToken) { }
        /// <summary>
        /// 获取收货区域
        /// </summary>
        /// <param name="city">城市名</param>
        /// <returns></returns>
        public ResponseModel<List<PickupAreaDto>> GetPickupArea(string city = "")
        {
            var resource = "pickupAreas";
            var parameters = new Dictionary<string, string>
            {
                {"City", city}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, null, parameters);
            var response = this._client.GenericExecute<List<PickupAreaDto>>(requests);
            return this.GetResult(response);
        }
        /// <summary>
        /// 创建收货订单
        /// </summary>
        public ResponseModel<object> CreatePickupOrder(CreatePickupOrderRequest request)
        {
            var resource = "pickupOrders";
            var requests = this._client.BuildRequest(Method.POST, resource,request);
            var response = this._client.Execute(requests);
            return this.GetResult(response);
        }
    }
}
