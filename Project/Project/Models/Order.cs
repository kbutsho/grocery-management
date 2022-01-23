using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductCategory { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerLocation { get; set; }

    }
}
