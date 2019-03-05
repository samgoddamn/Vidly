using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        protected readonly List<Customer> customers = new List<Customer> {
            new Customer { Name = "John Smith", Id = 1 },
            new Customer { Name = "Mary Williams", Id = 2 }};
        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Edit(int id)
        {
            var customer = customers.Find(x => x.Id == id);
            if (customer != null)
                return View(customer);
            else
            {
                return HttpNotFound();
            }

        }

        public ActionResult Detail(int id)
        {
            var customer = customers.Find(x => x.Id == id);
            if (customer != null)
                return View(customer);
            else
            {
                return HttpNotFound();
            }

        }
    }
}