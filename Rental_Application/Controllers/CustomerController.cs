using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental_Application.Models;
using System.Data.Entity;
using Rental_Application.ViewModels;

namespace Rental_Application.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult NewCustomer()
        {
            var MemberShipTypes = _context.MemberShipTypes.ToList();
            var viewmodel = new NewCustomerViewModel()
            {
                MemberShipTypes = MemberShipTypes
            };
            return View("NewCustomer", viewmodel);
        }

        [HttpPost]
        public ActionResult Save(Customer Customer)
        {
            if (!ModelState.IsValid)
            {
                var viewmodel = new NewCustomerViewModel
                {
                    customer = Customer,
                    MemberShipTypes = _context.MemberShipTypes.ToList()
                };
                return View("NewCustomer", viewmodel);
            }
            if (Customer.id == 0)
            {
                _context.Customers.Add(Customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.id == Customer.id);
                customerInDb.CustomerName = Customer.CustomerName;
                customerInDb.Birthdate = Customer.Birthdate;
                customerInDb.MembershipTypeId = Customer.MembershipTypeId;
                customerInDb.IsSubscribed = Customer.IsSubscribed;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
        // GET: Customer
        public ViewResult Index()
        {
            var customer = _context.Customers.Include(c => c.MemberShipType).ToList();
            return View(customer);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MemberShipType).SingleOrDefault(c => c.id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.id == id);
            var viewmodel = new NewCustomerViewModel
            {
                customer = customer,
                MemberShipTypes = _context.MemberShipTypes.ToList()
            };

            return View("NewCustomer", viewmodel);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {

        //    };
        //    //return new List<Customer>
        //    //{
        //    //    new Customer {id=1,CustomerName="Harsha" },
        //    //    new Customer {id=2,CustomerName="Rupesh" }

        //    //};
        //}
    }

}