using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.Services
{
    using System.Net;

    using CK1.OpenPlatform.SDK.HttpHelper;
    using CK1.OpenPlatform.SDK.Model;
    using CK1.OpenPlatform.SDK.Model.ErrorModel;
    using CK1.OpenPlatform.SDK.Model.OAuth2;

    using RestSharp;

    public class OAuth2Service
    {

        private readonly RestAPIExecutor _client = new RestAPIExecutor(null,Constants.OAuth2BaseUrl);

        /// <summary>
        /// 构建授权的Url，授权成功后，将跳转到RedirectUri并返回code参数
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetAuthorizeUrl(GetSignInUrlRequest request)
        {
            const string Resource = "authorization";

            var parameters = new Dictionary<string, string>
            {
                {"client_id", request.ClientId},
                {"response_type", request.ResponseType},
                {"scope", request.Scope},
                {"redirect_uri", request.RedirectUri},
            };

            var url = Resource + "?" + string.Join("&",
                parameters.Select(kp => string.Format("{0}={1}",
                    HttpClientFactory.UrlEncodeU8(kp.Key),
                    HttpClientFactory.UrlEncodeU8(kp.Value))));

            return this._client.BaseUrl + url;
        }

        /// <summary>
        /// 通过AutorizationCode获取RefreshToken和AccessToken
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ResponseModel<Token> GetToken(GetTokenRequest request)
        {
            const string Resource = "token";

            var parameters = new Dictionary<string, string>
            {
                {"client_id", request.ClientId},
                {"client_secret", request.ClientSecret},
                {"redirect_uri", request.RedirectUri},
                {"grant_type", "authorization_code"},
                {"code", request.Code},
            };

            var url = Resource + "?" + string.Join("&",
                parameters.Select(kp => string.Format("{0}={1}",
                    HttpClientFactory.UrlEncodeU8(kp.Key),
                    HttpClientFactory.UrlEncodeU8(kp.Value))));

            var requests = this._client.BuildRequest(Method.POST, url, null, parameters);
            var response = this._client.GenericExecute<Token>(requests);
            return this.GetResult(response);
        }

        /// <summary>
        /// 通过RefreshToken获取AccessToken
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ResponseModel<Token> GetAccessToken(GetTokenRequest request)
        {
            const string Resource = "token";

            var parameters = new Dictionary<string, string>
            {
                {"client_id", request.ClientId},
                {"client_secret", request.ClientSecret},
                {"refresh_token", request.RefreshToken},
                {"redirect_uri", request.RedirectUri},
                {"grant_type", "refresh_token"}
            };

            var url = Resource + "?" + string.Join("&", 
                parameters.Select(kp => string.Format("{0}={1}",
                    HttpClientFactory.UrlEncodeU8(kp.Key), 
                    HttpClientFactory.UrlEncodeU8(kp.Value))));

            var requests = this._client.BuildRequest(Method.POST, url, null, parameters);
            var response = this._client.GenericExecute<Token>(requests);
            return this.GetResult(response);
        }

        private ResponseModel<T> GetResult<T>(IRestResponse<T> response)
        {
            var result = new ResponseModel<T>();
            result.Result = response.Data;
            result.StatusCode = response.StatusCode;
            if (response.StatusCode.Equals(HttpStatusCode.OK))
            {
                result.Success = true;
            }
            else
            {
                result.Success = false;
                result.Error = new Ck1ErrorModel()
                {
                    Errors = new List<Ck1Error>()
                    {
                        new Ck1Error()
                        {
                            Code = string.Empty,
                            Message = response.Content
                        }
                    }
                };
            }
            return result;
        }
    }
}
