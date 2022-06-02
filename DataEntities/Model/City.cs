using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Model
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
