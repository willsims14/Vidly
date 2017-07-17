using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


// Possible return values for a controller method

//return new ViewResult();
//return new EmptyResult();
//return RedirectToAction("Index", "Home", new {page = 1, sortBy="name"});
//return HttpNotFound();
//return Content("Hello World");


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        // ViewModel way

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);


        }














        ///////////////////////////////////////////


        // 1st, Simple way (View)

        //public ActionResult Random()
        //{
        //var movie = new Movie() { Name = "Shrek!" };

        //return View(movie);
        //}


        ///////////////////////////////////////////
        // 2nd way (ViewResult) 

        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //var movie = new Movie(){Name = "Shrek!"};

        //var viewResult = new ViewResult();
        //viewResult.ViewData.Model = movie;

        //return viewResult;
        //}

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";


            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }

        // New way to define custom routes 
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}