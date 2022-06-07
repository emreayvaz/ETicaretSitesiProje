using BusinessLogicLayer;
using DataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
                return RedirectToAction("BasariliGiris");
            }

            return RedirectToAction("Error");
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult BasariliGiris()
        {
            ViewBag.session = Session["user"];
            ViewMasterPage master = new ViewMasterPage();
            return View();
        }

    }
}