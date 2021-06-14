using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAuthenticationSimple.Filters
{
    //// 繼承Attribute方便我們加在要Filter的地方能簡化程式碼,實作IAuthorizationFilter來做登入驗證
    public class Resorce : Attribute, Microsoft.AspNetCore.Mvc.Filters.IResourceFilter
    {
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (context.HttpContext.Request.ContentLength.HasValue)
            {
                if (context.HttpContext.Request.ContentLength.Value > 1024)
                {
                    context.Result = new Microsoft.AspNetCore.Mvc.ContentResult()
                    {
                        Content = "You can't upload file size over 1024KB."
                    };
                }
            }
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {

        }
    }
}
