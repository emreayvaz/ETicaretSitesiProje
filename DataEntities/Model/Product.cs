using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Model
{
    public class Product
    {
        [Key]
        public  int ID { get; set; }
        public string Name { get; set; }
        public string QuantityPerUnit { get; set; }
        public string UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string ImageUrlSmall { get; set; }
        public string ImageUrlBig { get; set; }
        public bool Status { get; set; }

        
        public int? SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public virtual Supplier Supplier { get; set; }
        
        public int? CategoryID { get; set; }

        [ForeignKey("CategoryID")]


        public virtual Category Category { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ProductImages> ProductImages { get; set; }

    }
}
