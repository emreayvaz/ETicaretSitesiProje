using BusinessLogicLayer;
using DataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ekle(Category item)
        {
            if (ModelState.IsValid)
            {
                repo.Insert(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }


    }
}