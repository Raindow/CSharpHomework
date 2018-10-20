using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
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
                throw new ArgumentException("the order has been already excited;");
            }

        }

        public Order seekOrder(string according)
        {
            return OrderList.Where(order => order.CusName == according || order.OrderNum == according).First();//要处理错误；
        }

        public bool deleteOrder(string according)
        {
            int i = 0;
            OrderList.Remove(seekOrder(according));
            OrderList.ForEach(order => {
                order.OrderNum = (i + 1).ToString();
                i++;
            });
            return true;
        }

        public Order seekOrderByTPrice(string tPrice)
        {
            if(double.TryParse(tPrice, out double totalPrice)) {
                return OrderList.Where(order => order.OrderDetails.TotalPrice == totalPrice).First();
            } else {
                throw new ArgumentException("Invalid input");
            }
        }
        public bool addOrderGoods(string according,string gName, string gQuantity, string gUPrice)
        {
            Order order = seekOrder(according);
            if (uint.TryParse(gQuantity, out uint quantity) && double.TryParse(gUPrice, out double uPrice)) {
                order.OrderDetails.addGoods(gName, quantity, uPrice);
            } else {
                throw new ArgumentException("Invalid quantity or unit price");
            }
            return true;

        }

        public bool deleteOrderGoods(string according, string gAccording)
        {
            Order order = seekOrder(according);
            order.OrderDetails.deleteGoods(gAccording);
            return true;
        }

        public bool renewOrderGoods(string according, string gAccording, string item, string newDate)
        {
            Order order = seekOrder(according);
            order.OrderDetails.renewGood(gAccording, item, newDate);
            return true;
        }
    }
}
