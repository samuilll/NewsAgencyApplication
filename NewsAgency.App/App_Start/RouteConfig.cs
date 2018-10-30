using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NewsAgency.App
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Error",
                url: "Error",
                defaults: new {controller = "Home", action = "Error"}
            );

            routes.MapRoute(
                name: "AllArticles",
                url: "AllArticles/Page{page}/Order-{order}",
                defaults: new {controller = "Article", action = "All", order = "default"}
            );
            routes.MapRoute(
                name: "AllCategories",
                url: "AllCategories/Page{page}/Order-{order}",
                defaults: new {controller = "Category", action = "All", order = "default"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new {controller = "Home", action = "Index", id = UrlParameter.Optional}
            );
        }
    }
}