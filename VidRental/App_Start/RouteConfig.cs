using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace VidRental
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //When creating Routes make sure that they taka a top down approach from most specific to most generic

            routes.MapMvcAttributeRoutes();
            /*routes.MapRoute(
                "MoviesByReleseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action = Old design "ByReleaseDate"},
                new { year = @"\d{4}", month = @"\d{2}"});
    */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
