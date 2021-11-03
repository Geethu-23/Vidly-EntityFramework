using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private MyDbContext _context = new MyDbContext();
        
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        public ViewResult Customer()
        {
            var customers = _context.customer;
            return View(customers);
        }
    }
}