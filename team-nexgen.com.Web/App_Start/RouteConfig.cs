using System.Web.Mvc;
using System.Web.Routing;
namespace team_nexgen.com {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Software",
                url: "Software",
                defaults: new { Controller = "Software", action = "Index" }
            );
            routes.MapRoute(
                name: "SoftwareDetail",
                url: "Software/{seoUrl}",
                defaults: new { Controller = "Software", action = "Detail", seoUrl = UrlParameter.Optional }
            );
        }
    }
}