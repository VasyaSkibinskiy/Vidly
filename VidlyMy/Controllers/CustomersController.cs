﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VidlyMy.Models;
using System.Data.Entity;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerContext _context;

        public CustomersController()
        {
            _context = new CustomerContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}