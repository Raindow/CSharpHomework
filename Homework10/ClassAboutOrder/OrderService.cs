using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ClassAboutOrder
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
            using (OrderDB db = new OrderDB()) {
                if (db.Order.ToList<Order>().Find(originalOrder => originalOrder.CustomerName == order.CustomerName) == null || db.Order.Count() == 0) {
                    string now = DateTime.Now.ToString("yyyyMMdd");
                    if (db.Order.Count() == 0 || Convert.ToUInt64(db.Order.ToList<Order>().Last().ID) < Convert.ToUInt64(now + "000")) {
                        order.ID = now + "001";
                        db.Order.Add(order);
                    } else {
                        order.ID = (Convert.ToUInt64(db.Order.ToList<Order>().Last().ID) + 1).ToString();
                        db.Order.Add(order);
                    }
                    db.SaveChanges();
                    return true;
                } else {
                  throw new ArgumentException("the order has been already existed;");
                }
            }
        }

        public Order seekOrder(string according)
        {
            using (OrderDB db = new OrderDB()) {
                return db.Order.SingleOrDefault(order => order.CustomerName == according || order.ID == according);//要处理错误；
            }
        }

        public bool deleteOrder(string according)
        {
            //Order order = seekOrder(according);
            using (OrderDB db = new OrderDB()) {
                //db.Order.Attach(order);
                //db.Entry(order).State = System.Data.Entity.EntityState.Deleted;
                //order = db.Order.Include("OrderDetails").SingleOrDefault(order1 => order1.ID == order.ID);
                //db.Goods.RemoveRange(order.Goods);
                //db.OrderDetails.Remove(order.OrderDetails);
                //var ordern = db.Order.Include("OrderDetails").Include("Goods").SingleOrDefault(order1 => order1.ID == "20181206001");
                //db.Goods.RemoveRange(ordern.Goods);
                //db.OrderDetails.Remove(ordern.OrderDetails);
                //db.Order.Remove(ordern);
                //db.SaveChanges();
                Order order = seekOrder(according);
                
            }
            return true;
        }

        public Order seekOrderByTPrice(string tPrice)
        {
            using (OrderDB db = new OrderDB()) {
                if (double.TryParse(tPrice, out double totalPrice)) {
                    return db.Order.Where(order => order.OrderDetails.TotalPrice == totalPrice).First();
                } else {
                    throw new ArgumentException("Invalid input");
                }
            }
        }
        public bool addOrderGoods(string according, string gName, string gQuantity, string gUPrice)
        {
            Order order = seekOrder(according);
            using (OrderDB db = new OrderDB()) {
                if (uint.TryParse(gQuantity, out uint quantity) && double.TryParse(gUPrice, out double uPrice)) {
                    Good good = new Good(gName, quantity, uPrice);
                    //order.OrderDetails.addGoods(good);
                    db.Order.Attach(order);                    
                    order.OrderDetails.addGoods(good);
                    db.OrderDetails.Attach(order.OrderDetails);
                    db.Entry(good).State = System.Data.Entity.EntityState.Added;
                   


                } else {
                    throw new ArgumentException("Invalid quantity or unit price");
                }
                db.SaveChanges();
              
            }
            return true;
        }

        public bool deleteOrderGoods(string according, string gAccording)
        {
            using (OrderDB db = new OrderDB()) {
                Order order = seekOrder(according);
                db.Order.Remove(order);
            }
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
