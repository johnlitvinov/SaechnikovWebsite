using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Saechnikov
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Jobs",
                url: "jobs",
                defaults: new { controller = "Home", action = "Jobs", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Thoughts",
                url: "thoughts",
                defaults: new { controller = "Home", action = "Thoughts", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Process",
                url: "process",
                defaults: new { controller = "Home", action = "Process", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Partners",
                url: "partners",
                defaults: new { controller = "Home", action = "Partners", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Contact",
                url: "contact",
                defaults: new { controller = "Home", action = "Contact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            


        }
    }
}
