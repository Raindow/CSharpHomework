using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutOrder
{
    class Order
    {
        public String Id { get; set; }
        public String Customer { get; set; }
        public DateTime CreateTime { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }
    }
}
