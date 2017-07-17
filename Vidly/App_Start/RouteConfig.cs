using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();


            // Old way to create custom route

            //routes.MapRoute(
                //"MoviesByReleastDate",
                //"movies/released/{year}/{month}",
                //new { controller = "Movies", action = "ByReleaseDate", },
                // Want the year to be a 4 digit number, and month to be a 2 digit number
                //new { year = @"\d{4}", month = @"\d{2}" });
            
            // New way to create custom route


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
