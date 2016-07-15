using CK1.OpenPlatform.SDK.HttpHelper;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Storage;
using System.Collections.Generic;
using RestSharp;

namespace CK1.OpenPlatform.SDK.Services
{
    /// <summary>
    /// 库存管理
    /// </summary>
    public class StorageService:OpenApiServiceBase
    {
        public StorageService(string accessToken) : base(accessToken) { }
        /// <summary>
        /// 查询Sku在某个仓库的库存情况（Get）
        /// </summary>
        public ResponseModel<List<InventoryDto>> GetInventory(GetInventoriesRequest request)
        {
            var resource = "inventories";
            var parameters = new Dictionary<string, string>
            {
                {"MerchantId", request.MerchantId},
                {"Skus", request.Skus},
                {"WarehouseId", request.WarehouseId}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, null, parameters);
            var response = this._client.GenericExecute<List<InventoryDto>>(requests);
            return this.GetResult(response);
        }
        /// <summary>
        /// 查询Sku在某个仓库的库存情况（Post）
        /// </summary>
        public ResponseModel<List<InventoryDto>> GetInventory(InventoriesRequest request)
        {
            var resource = "inventories";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.GenericExecute<List<InventoryDto>>(requests);
            return this.GetResult(response);
        }
        /// <summary>
        /// 查询某个仓库的仓储Sku列表
        /// </summary>
        public ResponseModel<ListStorageSkuResponse> ListStorageSku(ListStorageSkuRequest request)
        {
            var resource = "storageSkus";
            var parameters = new Dictionary<string, string>
            {
                {"WarehouseId", request.WarehouseId},
                {"PageIndex", request.PageIndex.ToString()},
                {"PageSize", request.PageSize.ToString()},
                {"Sorting", request.Sorting.ToString()}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, null, parameters);
            var response = this._client.GenericExecute<ListStorageSkuResponse>(requests);
            return this.GetResult(response);
        }
    }
}
