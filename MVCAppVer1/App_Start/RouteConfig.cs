using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCAppVer1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "BookDetail",
                url: "product/{url}-{id}", //{url}-{id}
                defaults: new { controller = "Product", action = "Detail" }
                );
            routes.MapRoute(
                name: "Search",
                url: "search",
                defaults: new { Controller = "Search", action = "SearchByName" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            routes.MapRoute(
                name: "NotFoundError",
                url: "{*url}",
                defaults: new { Controller = "Error", action = "PageNotFound" }
            );
        }
    }
}
