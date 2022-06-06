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
    public class ProductController : Controller
    {
        GenericRepository<Product> repo = new GenericRepository<Product>();
        Context db = new Context();
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

        public ActionResult Details(int? id)
        {
            Product product = db.Set<Product>().Find(id);
            return View(product);
        }

    }
}