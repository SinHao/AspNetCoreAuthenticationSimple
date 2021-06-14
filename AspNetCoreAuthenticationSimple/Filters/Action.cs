using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAuthenticationSimple.Filters
{
    public class Action : Attribute, Microsoft.AspNetCore.Mvc.Filters.IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.IsInRole("Admin"))
            {
                context.Result = new Microsoft.AspNetCore.Mvc.StatusCodeResult(Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden);
            }

            if(!context.ActionArguments.ContainsKey("value1"))
            {
                context.Result = new Microsoft.AspNetCore.Mvc.StatusCodeResult(Microsoft.AspNetCore.Http.StatusCodes.Status403Forbidden);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
          
        }
    }
}
