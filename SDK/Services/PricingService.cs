using CK1.OpenPlatform.SDK.HttpHelper;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Pricing;
using System.Collections.Generic;
using RestSharp;

namespace CK1.OpenPlatform.SDK.Services
{
    /// <summary>
    /// 计价查询
    /// </summary>
    public class PricingService:OpenApiServiceBase
    {
        public PricingService(string accessToken) : base(accessToken) { }

        /// <summary>
        /// 计算多个SKU产品在某种发货方式下的运费
        /// </summary>
        public ResponseModel<PricingResponse> GetSkusPricing(GetSkuPricingRequest request)
        {
            var resource = "pricing/outbound/skus";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.GenericExecute<PricingResponse>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 计算多个SKU产品在指定仓库所有可用发货方式的运费
        /// </summary>
        public ResponseModel<List<PricingResponse>> GetSkusPricingAll(GetSkuPricingAllRequest request)
        {
            var resource = "pricing/all/outbound/skus";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.GenericExecute<List<PricingResponse>>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 取得某个直发包裹信息发指定服务的运费
        /// </summary>
        public ResponseModel<PricingResponse> GetDirectExpressPricing(GetExpressPricingRequest request)
        {
            var resource = "pricing/directExpress/package";
            var parameters = new Dictionary<string, string>
            {
                {"ServiceCode", request.ServiceCode},
                {"LocationId", request.LocationId},
                {"Weight", request.Weight.ToString()},
                {"Length", request.Length.ToString()},
                {"Width", request.Width.ToString()},
                {"Height", request.Height.ToString()},
                {"Country", request.Country},
                {"Postcode", request.Postcode},
                {"Address", request.Address},
                {"Province", request.Province},
                {"City", request.City}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, null, parameters);
            var response = this._client.GenericExecute<PricingResponse>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 取得某个直发包裹信息的可用服务列表及所需运费
        /// </summary>
        public ResponseModel<List<PricingResponse>> GetDirectExpressPricingAll(GetExpressPricingAllRequest request)
        {
            var resource = "pricing/all/directExpress/package";
            var parameters = new Dictionary<string, string>
            {
                {"LocationId", request.LocationId},
                {"Weight", request.Weight.ToString()},
                {"Length", request.Length.ToString()},
                {"Width", request.Width.ToString()},
                {"Height", request.Height.ToString()},
                {"Country", request.Country},
                {"Postcode", request.Postcode},
                {"Address", request.Address},
                {"Province", request.Province},
                {"IncludeUnsuccessful", request.IncludeUnsuccessful.ToString()},
                {"City", request.City}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, null, parameters);
            var response = this._client.GenericExecute<List<PricingResponse>>(requests);
            return this.GetResult(response);
        }

    }
}
