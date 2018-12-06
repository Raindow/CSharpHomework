using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAboutOrder
{
    public class OrderDB: DbContext
    {
        public OrderDB() : base("OrderDataBase")
        {
        }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Good> Goods { get; set; }
    }
}
