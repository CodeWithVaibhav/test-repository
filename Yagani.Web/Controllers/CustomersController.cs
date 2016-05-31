using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Yagani.Web.Models;

namespace Yagani.Web.Controllers
{
    public class CustomersController : Controller
    {
        readonly List<Customer> _customers = new List<Customer>
        {
            new Customer{ Id=1, Name = "Vaibhav" },
            new Customer{ Id=2, Name = "Abhishek" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(_customers);
        }

        public ActionResult Customer(int id)
        {
            var result = _customers.Where(s => s.Id == id);
            return View(result);
        }
    }
}