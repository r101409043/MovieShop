using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MovieShop.MVC.Filters
{
    public class LogRequestAttribute() : TypeFilterAttribute(typeof(LogRequestFilter));
}