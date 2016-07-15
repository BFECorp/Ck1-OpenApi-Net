using CK1.OpenPlatform.SDK.HttpHelper;

namespace CK1.OpenPlatform.SDK.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using CK1.OpenPlatform.SDK.Model;
    using CK1.OpenPlatform.SDK.Model.ErrorModel;

    using Newtonsoft.Json;

    using RestSharp;

    public abstract class OpenApiServiceBase
    {
        protected OpenApiServiceBase(string accessToken)
        {
            _client = new RestAPIExecutor(accessToken);
        }
        protected readonly RestAPIExecutor _client;

        protected ResponseModel<T> GetResult<T>(IRestResponse<T> response)
        {
            var result = new ResponseModel<T>();
            result.Result = response.Data;
            result.StatusCode = response.StatusCode;
            if (response.StatusCode.Equals(HttpStatusCode.Created) || response.StatusCode.Equals(HttpStatusCode.OK))
            {
                result.Success = true;
            }
            else
            {
                result.Success = false;
                try
                {
                    result.Error = JsonConvert.DeserializeObject<Ck1ErrorModel>(response.Content);
                }
                catch (Exception ex)
                {
                    result.Error = new Ck1ErrorModel()
                    {
                        Errors = new List<Ck1Error>()
                        {
                            new Ck1Error()
                            {
                                Code = "",
                                Message = response.Content
                            }
                        }
                    };
                }
                
            }
            return result;
        }

        protected ResponseModel<object> GetResult(IRestResponse response)
        {
            var result = new ResponseModel<object>();
            result.Result = null;
            result.StatusCode = response.StatusCode;
            if (response.StatusCode.Equals(HttpStatusCode.Created) || response.StatusCode.Equals(HttpStatusCode.OK))
            {
                result.Success = true;
            }
            else
            {
                result.Success = false;
                try
                {
                    result.Error = JsonConvert.DeserializeObject<Ck1ErrorModel>(response.Content);
                }
                catch (Exception ex)
                {
                    result.Error = new Ck1ErrorModel()
                    {
                        Errors = new List<Ck1Error>()
                        {
                            new Ck1Error()
                            {
                                Code = "",
                                Message = response.Content
                            }
                        }
                    };
                }
            }
            return result;
        }
    }
}
