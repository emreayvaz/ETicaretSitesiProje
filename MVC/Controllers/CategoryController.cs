using BusinessLogicLayer;
using DataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Context;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        GenericRepository<Category> repo = new GenericRepository<Category>();
        Context db = new Context(); 
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
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category category = db.Set<Category>().Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
    }
}