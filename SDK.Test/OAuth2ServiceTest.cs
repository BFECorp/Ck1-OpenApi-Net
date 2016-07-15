using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Test
{
    using CK1.OpenPlatform.SDK.Model.OAuth2;
    using CK1.OpenPlatform.SDK.Services;

    using Newtonsoft.Json;

    public class OAuth2ServiceTest
    {

        private OAuth2Service _service;

        private const string ClientId = "your app client_id";
        private const string ClientSecret = "your app ent_secret";
        private const string RedirectUri = "your app redirect_uri";

        private const string OpenApiScope = "OpenApi";  //多个scope用逗号分隔

        // OAuth2 授权流程
        // 1. 调用GetSignInUrl方法构建SignInUrl，并引导客户到SignInUrl进行登陆和授权
        // 2. 授权成功后，会自动跳转到RedirectUri，并在该页面接收authorization code
        // 3. 获取到授权码Code之后，再调用GetToken方法获取AccessToken和RefreshToken

        public OAuth2ServiceTest()
        {
            this._service = new OAuth2Service();
        }

        public void TestGetSignInUrl()
        {
            var request = new GetSignInUrlRequest()
            {
                ClientId = ClientId,
                ResponseType = "Code",
                Scope = OpenApiScope,
                RedirectUri = "http://{your domain}/oauth2/return",
            };
            var result = this._service.GetAuthorizeUrl(request);

            Console.WriteLine(result);

            // 注意RedirectUri需要与注册App的RedirectUri同源，否则会返回以下错误
            // Portal:800F0610 Message: 请求授权应用的重定向地址与应用注册时回调地址非同源

            // 授权成功后，会跳转到类似如下地址 
            // http://{your domain}/oauth2/return?code={Code}
        }

        public void TestGetTokenShouldPass()
        {
            var code = "ZjhiZmExZjctMzdhMy00YzkxLTgzYzMtMWQzMDliMWI2NDhl";
            var request = new GetTokenRequest()
            {
                ClientId = ClientId,
                ClientSecret = ClientSecret,
                RedirectUri = RedirectUri,
                Code = code
            };
            var result = this._service.GetToken(request);

            Console.WriteLine(JsonConvert.SerializeObject(result));
        }


        public void TestGetAccessTokenShouldPass()
        {
            var request = new GetTokenRequest()
            {
                ClientId = ClientId,
                ClientSecret = ClientSecret,
                RefreshToken = "{RefreshToken}",
                RedirectUri = RedirectUri,
            };
            var result = this._service.GetAccessToken(request);

            Console.WriteLine(JsonConvert.SerializeObject(result));
        }

        public void TestGetAccessTokenShouldNotPass()
        {
            var request = new GetTokenRequest()
            {
                ClientId = ClientId + "abc",
                ClientSecret = ClientSecret,
                RefreshToken = "{RefreshToken}",
                RedirectUri = RedirectUri,
            };
            var result = this._service.GetAccessToken(request);

            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}
