using BusinessLogicLayer;
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
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }

    }
}