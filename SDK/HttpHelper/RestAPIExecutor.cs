namespace CK1.OpenPlatform.SDK.HttpHelper
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web;

    using RestSharp;

    public class RestAPIExecutor
    {
        private const string ApplicationName = "CK1 OpenApi SDK";
        private const string ApplicationVersion = "1.0";
        private const string ProgrammingLanguage = "C#";

        private Dictionary<string, string> Headers;

        private const string DefaultDateParameterFormat = "yyyy-MM-ddTHH:mm:ssZ";
        
        private RestClient client;

        public RestAPIExecutor(string accessToken,string baseUrlConfigeName = null)
        {
            this.Headers = new Dictionary<string, string>()
            {
                {"Content-Type", "application/json; charset=utf-8"},
                {"API-RemoteIP", GetClientIp()},
                {"Authorization", "Bearer " + accessToken}
            };

            if (string.IsNullOrEmpty(baseUrlConfigeName))
            {
                // 默认为OpenApiBaseUrl
                baseUrlConfigeName = Constants.OpenApiBaseUrl;
            }

            this.client = HttpClientFactory.Create(baseUrlConfigeName);
            this.client.UserAgent = this.UserAgent;

        }

        public Uri BaseUrl
        {
            get
            {
                return this.client.BaseUrl;
            }
        }

        public string UserAgent
        {
            get
            {
                return string.Format("{0}/{1}({2})", ApplicationName, ApplicationVersion, ProgrammingLanguage);
            }
        }

        /// <summary>
        /// 取得用户IP地址.
        /// </summary>
        /// <returns>用户IP地址.</returns>
        public static string GetClientIp()
        {
            var context = HttpContext.Current;
            var ip = string.Empty;
            if (context != null)
            {
                if (!string.IsNullOrEmpty(context.Request.UserHostAddress))
                {
                    ip = context.Request.UserHostAddress;
                }
            }

            return ip;
        }

        public RestRequest BuildRequest(Method httpMethod, string resource)
        {
            return this.BuildRequest(httpMethod, resource, null, null, null);
        }

        public RestRequest BuildRequest(Method httpMethod, string resource, Dictionary<string, string> urlSegments, Dictionary<string, string> parameters)
        {
            return this.BuildRequest(httpMethod, resource, urlSegments, parameters, null);
        }

        public RestRequest BuildRequest(Method httpMethod, string resource, object body)
        {
            return this.BuildRequest(httpMethod, resource, null, null, body);
        }

        public RestRequest BuildRequest(Method httpMethod, string resource, Dictionary<string, string> urlSegments, Dictionary<string, string> parameters, object body)
        {
            var request = new RestRequest(resource,httpMethod)
            {
                RequestFormat = DataFormat.Json
            };
            foreach (var header in this.Headers)
            {
                request.AddHeader(header.Key, header.Value);
            }

            if (urlSegments != null)
            {
                foreach (var urlSegment in urlSegments)
                {
                    request.AddUrlSegment(urlSegment.Key, urlSegment.Value);
                }
            }
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    request.AddParameter(parameter.Key, parameter.Value);
                }
            }
            if (body != null)
            {
                request.AddJsonBody(body);
            }

            return request;
        }

        public IRestResponse<T> GenericExecute<T>(RestRequest request) where T : new()
        {
            request.DateFormat = DefaultDateParameterFormat;

            var response = this.client.Execute<T>(request);

            return response;
        }

        public RestRequestAsyncHandle AsyncGenericExecute<T>(RestRequest request, Action<IRestResponse<T>> action) where T : new()
        {
            request.DateFormat = DefaultDateParameterFormat;
            return this.client.ExecuteAsync<T>(request, action);
        }

        public Task<T> GetTaskAsync<T>(RestRequest request) where T : new()
        {
            request.DateFormat = DefaultDateParameterFormat;
            return this.client.GetTaskAsync<T>(request);
        }

        public IRestResponse Execute(RestRequest request)
        {
            request.DateFormat = DefaultDateParameterFormat;

            var response = this.client.Execute(request);

            return response;
        }

        public byte[] DownloadData(RestRequest request)
        {
            return this.client.DownloadData(request);
        }

    }
}