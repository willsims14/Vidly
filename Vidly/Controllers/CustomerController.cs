using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>();

            customers.Add(new Customer() {Name = "Will Sims", Id=0});
            customers.Add(new Customer() {Name = "Joe Bob", Id=1});

            var viewResult = new ViewResult();

            viewResult.ViewData.Model = customers;

            return View(customers);
        }



        //public ActionResult Random()
        //{
        //var movie = new Movie(){Name = "Shrek!"};

        //var viewResult = new ViewResult();
        //viewResult.ViewData.Model = movie;

        //return viewResult;
        //}


    }
}