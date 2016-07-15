using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.HttpHelper
{
    using System.Configuration;

    using RestSharp;
    using RestSharp.Extensions.MonoHttp;

    public class HttpClientFactory
    {
        private static readonly Encoding UTF8_ENCODING = Encoding.UTF8;

        /// <summary>
        /// 创建RestClient对象
        /// </summary>
        /// <param name="baseUrlConfigeName">基地址配置名</param>
        /// <returns>RestClient对象</returns>
        public static RestClient Create(string baseUrlConfigeName)
        {
            var baseUrl = ConfigurationManager.AppSettings[baseUrlConfigeName];
            if (String.IsNullOrWhiteSpace(baseUrl))
            {
                throw new ConfigurationErrorsException("missing \"" + baseUrlConfigeName + "\" appSetting.");
            }

            return new RestClient(baseUrl);
        }

        /// <summary>
        /// 进行UTF-8编码
        /// </summary>
        /// <param name="s">要编码的字符串</param>
        /// <returns></returns>
        public static String UrlEncodeU8(String s)
        {
            return HttpUtility.UrlEncode(s, UTF8_ENCODING);
        }
    }
}
