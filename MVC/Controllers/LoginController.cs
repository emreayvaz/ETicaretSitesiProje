using BusinessLogicLayer;
using DataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        GenericRepository<Customer> cRepo = new GenericRepository<Customer>();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if (cRepo.GetAll().Where(c => c.UserName == username && c.Password == password).Count()==1)
            {
                Customer customer = new Customer();
                customer.UserName = username;
                customer.Password = password;
                FormsAuthentication.SetAuthCookie(customer.UserName, false);
                Session["UserName"] = customer.UserName;
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Error");
        }
        public ActionResult Error()
        {
            return View();
        }

        public ActionResult Exit()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }

    }
}