using CK1.OpenPlatform.SDK.HttpHelper;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.DataYewu;
using System.Collections.Generic;
using RestSharp;

namespace CK1.OpenPlatform.SDK.Services
{
    /// <summary>
    /// 数据列表
    /// </summary>
    public class DataService:OpenApiServiceBase
    {
        public DataService(string accessToken) : base(accessToken) { }
        /// <summary>
        /// 查询海外仓库列表
        /// </summary>
        public ResponseModel<List<WarehouseDto>> ListWarehouse()
        {
            var resource = "warehouses";
            var requests = this._client.BuildRequest(Method.GET, resource);
            var response = this._client.GenericExecute<List<WarehouseDto>>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 查询处理点列表
        /// </summary>
        public ResponseModel<List<LocationDto>> ListLocation()
        {
            var resource = "locations";
            var requests = this._client.BuildRequest(Method.GET, resource);
            var response = this._client.GenericExecute<List<LocationDto>>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 查询某仓库二程发货服务列表
        /// </summary>
        /// <param name="warehouseId">仓库代码</param>
        public ResponseModel<List<OutboundServiceDto>> GetOutboundService(string warehouseId)
        {
            var resource = "outboundServices/{warehouseId}";
            var urlSegments = new Dictionary<string, string>
            {
                {"warehouseId", warehouseId}
            };
            var requests = this._client.BuildRequest(Method.GET, resource, urlSegments, null);
            var response = this._client.GenericExecute<List<OutboundServiceDto>>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 查询中国直发服务列表
        /// </summary>
        public ResponseModel<List<DirectExpressServiceDto>> GetDirectExpressServices()
        {
            var resource = "directExpressServices";
            var requests = this._client.BuildRequest(Method.GET, resource);
            var response = this._client.GenericExecute<List<DirectExpressServiceDto>>(requests);
            return this.GetResult(response);
        }

    }
}
