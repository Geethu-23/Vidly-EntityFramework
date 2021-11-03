using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        /* public ActionResult Random()
         {
             var movie = new Movie() { Name = "Frozen" };
             // return View(movie); // This method will carry Movie model data to the view Random
             // return Content("Hello World"); // This method will return the content passed in the argument
             //return HttpNotFound (); // This method will return error page as Not Found in UI
             //return new EmptyResult();// This method wil return empty page
             return RedirectToAction("Contact","Home"); // This method will redirect to new view page as per the argument passed

         }*/

        private MyDbContext _context = new MyDbContext();

        public ViewResult Movie()
        {
            var movie = _context.movie;
            return View(movie);
        }




        public ActionResult Random()
        {
            var movie = new List<Movie>
            {
                new Movie {Name = "Frozen" },
                new Movie {Name="Vennom"},
                new Movie {Name = "Jumanji"}
            };
            
           
            var customers = new List<Customer>
            {
                new Customer {Name="Customer1"},
                new Customer {Name="Customer2"}


            };

            var viewModel = new RandomMovieViewModel
            {
                smallmoviebag = movie,
                smallcustomerbag = customers
            };



            return View(viewModel);

        }






    }
}