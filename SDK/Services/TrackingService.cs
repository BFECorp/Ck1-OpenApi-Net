using CK1.OpenPlatform.SDK.HttpHelper;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Tracking;
using System.Collections.Generic;
using RestSharp;

namespace CK1.OpenPlatform.SDK.Services
{
    /// <summary>
    /// 轨迹查询
    /// </summary>
    public class TrackingService:OpenApiServiceBase
    {
        public TrackingService(string accessToken) : base(accessToken) { }

        /// <summary>
        /// 获取当前账号的包裹轨迹信息
        /// </summary>
        /// <param name="trackingNumber">跟踪号或处理号</param>
        public ResponseModel<GetTrackingResponse> GetTracking(string trackingNumber)
        {
            var resource = "trackings/{trackingNumber}";
            var urlSegments = new Dictionary<string, string>
            {
                {"trackingNumber", trackingNumber}
            };
            var requests = this._client.BuildRequest(Method.GET, resource,urlSegments, null);
            var response = this._client.GenericExecute<GetTrackingResponse>(requests);
            return this.GetResult(response);
        }
    }
}
