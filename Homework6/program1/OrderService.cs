using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace program1
{
    [Serializable]
    public class OrderService
    {
        public List<Order> OrderList;

        public OrderService()
        {
            OrderList = new List<Order>();
        }

        public bool addOrder(Order order)
        {
            if (OrderList.Find(originalOrder => originalOrder.CusName == order.CusName) == null || OrderList.Count == 0) {
                order.OrderNum = (OrderList.Count + 1).ToString();
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
            if (double.TryParse(tPrice, out double totalPrice)) {
                return OrderList.Where(order => order.OrderDetails.TotalPrice == totalPrice).First();
            } else {
                throw new ArgumentException("Invalid input");
            }
        }
        public bool addOrderGoods(string according, string gName, string gQuantity, string gUPrice)
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

        public void Export(string XFName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(XFName, FileMode.Create)) {
                xmlSerializer.Serialize(fs, OrderList);
            }
        }

        public void Import(string XFName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(XFName, FileMode.Open)) {
                OrderList = (List<Order>)xmlSerializer.Deserialize(fs);
                OrderList.ForEach(o => Console.WriteLine(o.ToString()));
            }
        }
    }
}
