using DataEntities.Model;
using System.Collections.Generic;

namespace MVC.Models
{
    public class UrunlerKategoriler
    {
        public List<Category> Kategoriler { get; set; }
        public List<Product> Urunler { get; set; }
    }
}