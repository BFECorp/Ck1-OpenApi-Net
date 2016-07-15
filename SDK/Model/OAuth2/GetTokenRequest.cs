using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.Model.OAuth2
{
    public class GetTokenRequest
    {
        public string ClientId { get; set; }

        public string ClientSecret { get; set; }

        public string RefreshToken { get; set; }

        public string RedirectUri { get; set; }

        public string Code { get; set; }
    }
}
