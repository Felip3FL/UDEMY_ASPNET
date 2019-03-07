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
    }
}