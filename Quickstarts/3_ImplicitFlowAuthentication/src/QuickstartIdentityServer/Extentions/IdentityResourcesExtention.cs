using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace QuickstartIdentityServer.Extentions
{


    public static class IdentityResourcesExtention
    {
        /// <summary>Models the standard openid scope</summary>
        /// <seealso cref="T:IdentityServer4.Models.IdentityResource" />
        public class MyWebAppScope : IdentityResource
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="T:IdentityServer4.Models.IdentityResources.OpenId" /> class.
            /// </summary>
            public MyWebAppScope()
            {
                this.Name = "MyWebAppScope";
                this.DisplayName = "My first Web Ap pScope";
                this.Required = false;
                this.UserClaims.Add("myclaim1");
                this.UserClaims.Add("myclaim2");
            }
        }
    }
}
