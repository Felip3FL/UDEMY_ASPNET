using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UDEMY_ASPNET
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //   Route para muitos parametros 
            //   (Essa routa precisa está no topo, para ser a primeira a ser chamada):
            //   /movies/released/2015/04
            routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" }, //deafault values
                new { year = @"\d{4}", month = @"\d{2}"}
                //new { year = @"2015|2016", month = @"\d{2}"}
                );

            //Preciso mudar aqui o {id} para {movieId} para que funcione esse link:
            //http://localhost:50328/movies/edit/100
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
