using DataEntities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class UrunlerKategoriler
    {
        public List<Category> Kategoriler { get; set; }
        public List<Product> Urunler { get; set; }
    }
}