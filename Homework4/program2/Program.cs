using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Order customer = new Order();
                Console.WriteLine("your name：");
                customer.CusName = Console.ReadLine();
                Console.WriteLine("your thing：");
                customer.Thing = Console.ReadLine();
                Order cust1omer = new Order();
                cust1omer.CusName = "1m";
                cust1omer.Thing = "oll";
                Order cust2omer = new Order();
                cust2omer.CusName = "2";
                cust2omer.Thing = "frg";
                OrderService orderService = new OrderService();
                orderService.addOrder(customer);
                orderService.addOrder(cust1omer);
                orderService.addOrder(cust2omer);
                Console.WriteLine(orderService.seekOrder("oll"));
                Console.WriteLine(orderService.OrderList[orderService.seekOrder("oll")].CusName);
                Console.WriteLine(orderService.changeOrder("CusName", "1m", "89"));
                Console.WriteLine(orderService.OrderList[1].CusName);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
           
    }
}
