using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.DTO
{
    public class OrderDTO
    {
        public int Customer_id { get; set; }
        public List<int> Products { get; set; }
    }
}
