using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAuthenticationSimple.Filters
{
    //// 繼承Attribute方便我們加在要Filter的地方能簡化程式碼,實作IAuthorizationFilter來做登入驗證
    public class Authorization : Attribute, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if(!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.HttpContext.Response.StatusCode = 403;
            }
        }
    }
}
