using BusinessLogicLayer;
using DataAccessLayer.Context;
using DataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        GenericRepository<Customer> cRepo = new GenericRepository<Customer>();
        GenericRepository<City> cityRepo = new GenericRepository<City>();
        public ActionResult Index()
        {
            return View(cRepo.GetAll());
        }
        [HttpGet]
        public ActionResult MusteriKayit()
        {
            List<SelectListItem> sehirler = new List<SelectListItem>();
            foreach (var item in cityRepo.GetAll())
            {
                sehirler.Add(new SelectListItem { Text = item.Name, Value = item.ID.ToString() });
            }
            ViewBag.Sehirler = sehirler;
            return View();
        }
        [HttpPost]
        public ActionResult MusteriKayit(Customer item)
        {
            cRepo.Update(item);
            return RedirectToAction("Index");
        }
    }
}