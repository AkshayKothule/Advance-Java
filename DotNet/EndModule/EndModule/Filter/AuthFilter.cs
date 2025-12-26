using Microsoft.AspNetCore.Mvc.Filters;

namespace EndModule.Filter;

public class AuthFilter : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.HttpContext.Session.GetString("Name") == null)
        {
            context.HttpContext.Response.Redirect("/Login/SignIn");
            
        }
    }
}