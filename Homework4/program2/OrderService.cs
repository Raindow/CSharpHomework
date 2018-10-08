using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService
    {
        public List<Order> OrderList = new List<Order>();
        public bool addOrder(Order order)
        {
            if(OrderList.Find(originalOrder => originalOrder.CusName == order.CusName) == null) {
                order.OrderNum = OrderList.Count.ToString();
                OrderList.Add(order);
                return true;
            } else {
                return false;
            }

        }
        public int seekOrder(string according)
        {
            try {
                return OrderList.FindIndex(order => order.CusName == according || order.OrderNum == according || order.Thing == according);
            }
            catch (ArgumentNullException e){
                Console.WriteLine("there's no such order.");
                return -1;
            }
        }
        public bool deleteOrder(string according)
        {
            if (seekOrder(according) >= 0) {
                int i = 0;
                OrderList.RemoveAt(seekOrder(according));
                OrderList.ForEach(order => {
                    order.OrderNum = (i + 1).ToString();
                    i++;
                });
                return true;
            } else {
                return false;
            }
        }
        public bool changeOrder(string item, string according, string transformation)
        {
            try {
                if (seekOrder(according) >= 0) {
                    switch (item) {
                        case "CusName":
                            OrderList[seekOrder(according)].CusName = transformation;
                            break;
                        case "OrderNum":
                            OrderList[seekOrder(according)].OrderNum = transformation;
                            break;
                        case "Thing":
                            OrderList[seekOrder(according)].Thing = transformation;
                            break;
                        default:
                            throw new Exception("there's no such item.");
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
