using BusinessLogicLayer;
using DataEntities.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        GenericRepository<Customer> cRepo = new GenericRepository<Customer>();
        List<Product> sepet = new List<Product>();
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
                customer = cRepo.GetAll().Where(c => c.UserName == username).FirstOrDefault();
                FormsAuthentication.SetAuthCookie(customer.UserName, false);
                Session["UserId"] = customer.ID;
                Session["Sepet"] = sepet;               
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