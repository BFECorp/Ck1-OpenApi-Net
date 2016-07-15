using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.Model.OAuth2
{
    public class Token
    {
        public string AccessToken { get; set; }

        public int AccessTokenExpiresIn { get; set; }

        public int RefreshTokenExpiresIn { get; set; }

        public string RefreshToken { get; set; }

        public string CustomerId { get; set; }
    }
}
