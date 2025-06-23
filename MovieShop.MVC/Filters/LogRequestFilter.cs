using Microsoft.AspNetCore.Mvc.Filters;

namespace MovieShop.MVC.Filters
{
    public class LogRequestFilter(ILogger<LogRequestFilter> logger) : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            var action = context.RouteData.Values["action"];
            var method = context.HttpContext.Request.Method;
            var path = context.HttpContext.Request.Path;

            logger.LogInformation("📥 Request to {Controller}.{Action} [{Method}] at {Path}",
                controller, action, method, path);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}