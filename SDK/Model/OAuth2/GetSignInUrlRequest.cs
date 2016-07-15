using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CK1.OpenPlatform.SDK.Model.OAuth2
{
    public class GetSignInUrlRequest
    {
        /// <summary>
        /// Client Id
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Code or Token
        /// </summary>
        public string ResponseType { get; set; }

        /// <summary>
        /// OpenApi
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Custom Url
        /// </summary>
        public string RedirectUri { get; set; }
    }
}
