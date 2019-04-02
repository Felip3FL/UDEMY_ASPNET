using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UDEMY_ASPNET.Models;

namespace UDEMY_ASPNET.Controllers
{
    public class MoviesController : Controller
    {

        //https://blog.eduonix.com/web-programming-tutorials/learn-different-types-of-action-results-in-mvc/
        //https://docs.microsoft.com/pt-br/dotnet/api/system.web.mvc.actionresult?view=aspnet-mvc-5.2#derived

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
            //return Content("Olá Mundo!!!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);

            //Para realizar o teste: 
            //http://localhost:50328/movies/edit/100
            //http://localhost:50328/movies/edit?id=10
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));

            //Para realizar o teste: 
            //http://localhost:50328/movies?pageindex=10
            //http://localhost:50328/movies?pageindex=10&sortby=releasedate

        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);

            //Relizar teste:
            //http://localhost:50328/movies/released/2015/04
        }

    }
}