using System.Collections.Generic;
using CK1.OpenPlatform.SDK.HttpHelper;
using CK1.OpenPlatform.SDK.Model;
using CK1.OpenPlatform.SDK.Model.Rma;
using RestSharp;

namespace CK1.OpenPlatform.SDK.Services
{
    /// <summary>
    /// 退货服务
    /// </summary>
    public class RmaService:OpenApiServiceBase
    {
        public RmaService(string accessToken) : base(accessToken) { }

        /// <summary>
        /// 创建退货单，并获取退货标签
        /// </summary>
        public ResponseModel<LabelObject> GetRmaLabel(GetRmaOrderLabelRequest request)
        {
            var resource = "rmas/label";
            var requests = this._client.BuildRequest(Method.POST, resource, request);
            var response = this._client.GenericExecute<LabelObject>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 查询某个仓库的退货信息列表
        /// </summary>
        public ResponseModel<ListRmasResponse> ListRmas(ListRmasRequest request)
        {
            var resource = "rmas";
            var parameters = new Dictionary<string, string>
            {
                {"RmaWarehouseId", request.RmaWarehouseId},
                {"HandleTimeStart", request.HandleTimeStart},
                {"HandleTimeEnd", request.HandleTimeEnd},
                {"Status", request.Status.ToString()},
                {"CreateTimeStart", request.CreateTimeStart},
                {"CreateTimeEnd", request.CreateTimeEnd},
                {"PageIndex", request.PageIndex.ToString()},
                {"PageSize", request.PageSize.ToString()}
            };
            var requests = this._client.BuildRequest(Method.GET, resource,null, parameters);
            var response = this._client.GenericExecute<ListRmasResponse>(requests);
            return this.GetResult(response);
        }
    }
}
