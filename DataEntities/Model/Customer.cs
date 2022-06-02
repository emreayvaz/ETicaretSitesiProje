using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities.Model
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        
        public int? CityID { get; set; }
        [ForeignKey("CityID")]
        public virtual City City { get; set; }

    }
}
