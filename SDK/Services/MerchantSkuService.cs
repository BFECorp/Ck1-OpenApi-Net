namespace CK1.OpenPlatform.SDK.Services
{
    using System.Collections.Generic;

    using CK1.OpenPlatform.SDK.HttpHelper;
    using CK1.OpenPlatform.SDK.Model;
    using CK1.OpenPlatform.SDK.Model.MerchantSku;

    using RestSharp;
    /// <summary>
    /// 商户与SKU
    /// </summary>
    public class MerchantSkuService : OpenApiServiceBase
    {
        public MerchantSkuService(string accessToken) : base(accessToken) { }
        /// <summary>
        /// 创建商户
        /// </summary>
        public ResponseModel<object> CreateMerchant(CreateMerchantRequest request)
        {
            var resource = "merchants";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.Execute(requests);
            return this.GetResult(response);
        }
        /// <summary>
        /// 创建sku
        /// </summary>
        public ResponseModel<object> CreateMerchantSku(CreateMerchantSkuRequest request)
        {
            var resource = "merchantSkus";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.Execute(requests);
            return this.GetResult(response);
        }
        /// <summary>
        /// 获取Sku库存编码标签
        /// </summary>
        public ResponseModel<LabelObject> GetSkuLabel(GetSkuLabelRequest request)
        {
            var resource = "merchantSkus/label";
            var parameters = new Dictionary<string, string>
            {
                {"MerchantId", request.MerchantId},
                {"WarehouseId", request.WarehouseId},
                {"Sku", request.Sku},
                {"Quantity", request.Quantity.ToString()},
                {"PrintFormat", request.PrintFormat.ToString()}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, null, parameters);
            var response = this._client.GenericExecute<LabelObject>(requests);
            return this.GetResult(response);
        }
    }
}
