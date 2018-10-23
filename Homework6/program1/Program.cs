using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    public class Program
    {
        static void Main(string[] args)
        {
            try {
                OrderService orderSeevice = new OrderService();
                Order order = new Order();
                order.CusName = "1";
                order.OrderDetails.addGoods("258", 20, 36);
                orderSeevice.addOrder(order);
                orderSeevice.Export("1.xml");
                orderSeevice.Import("1.xml");
            }
            catch (InvalidOperationException e) {
                Console.WriteLine("there's no such thing");
            }
            catch (ArgumentException e) {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
