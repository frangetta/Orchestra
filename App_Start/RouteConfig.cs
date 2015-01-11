using System.Web.Mvc;
using System.Web.Routing;

namespace Orchestra
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("HomeIndex", "", new {controller = "Home", action = "Index"});
            routes.MapRoute("DivisionItem", "{*path}", new { controller = "Division", action = "Item" });
        }
    }
}
