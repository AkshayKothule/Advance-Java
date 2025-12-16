using Microsoft.AspNetCore.Mvc.Filters;
using MVCLab.Logger;
namespace MVCLab.Filters;


public class LogFilter : ActionFilterAttribute
{
   public override void OnActionExecuting(ActionExecutingContext Context)
   {
      FileLogger.CurrentLogger.Log("Called "+Context.HttpContext.Request.Path);
      
   }

   public override void OnActionExecuted(ActionExecutedContext Context)
   {
      FileLogger.CurrentLogger.Log("Complted "+Context.HttpContext.Request.Path);
      
   }
    
}