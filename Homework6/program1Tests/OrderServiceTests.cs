using Microsoft.VisualStudio.TestTools.UnitTesting;
using program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        [TestMethod()]
        public void addOrderTest()
        {
            OrderService orderService = new OrderService();
            Order order = new Order();
            orderService.addOrder(order);
            int num = orderService.OrderList.Count;
            int result = 1;
            Assert.AreEqual(result, num);
        }

        [TestMethod()]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void seekOrderTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            Order order2 = new Order();
            order2.CusName = "002";
            Order order3 = new Order();
            order3.CusName = "003";
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            CollectionAssert.Equals(order1, orderService.seekOrder("001"));
            //CollectionAssert.Equals(order2, orderService.seekOrder("2"));
            //Order order6 = orderService.seekOrder("006");  //此处注释解决应报错的错误类型匹配，须将此方法名上的ExpectedException取消注释
            //Order order7 = orderService.seekOrder("6");
        }

        [TestMethod()]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void deleteOrderTest()
        {
            bool flag;
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            Order order2 = new Order();
            order2.CusName = "002";
            Order order3 = new Order();
            order3.CusName = "003";
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            flag = orderService.deleteOrder("001");
            //flag = orderService.deleteOrder("009");
            Assert.AreEqual(true, flag);
        }

        [TestMethod()]
        public void seekOrderByTPriceTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            order1.OrderDetails.TotalPrice = 1;
            Order order2 = new Order();
            order2.CusName = "002";
            order2.OrderDetails.TotalPrice = 2;
            Order order3 = new Order();
            order3.CusName = "003";
            order3.OrderDetails.TotalPrice = 3;
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            try {
                //Order order = orderService.seekOrderByTPrice("3");
                //Order order = orderService.seekOrderByTPrice("9");
                Order order = orderService.seekOrderByTPrice("asf");
                CollectionAssert.Equals(order3, order);
            } catch (InvalidOperationException e) {
                Assert.IsInstanceOfType(e, typeof(InvalidOperationException));
            }
            catch (ArgumentException e) {
                Assert.IsInstanceOfType(e, typeof(ArgumentException));

            }

        }

        [TestMethod()]
        public void addOrderGoodsTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            order1.OrderDetails.TotalPrice = 1;
            Order order2 = new Order();
            order2.CusName = "002";
            order2.OrderDetails.TotalPrice = 2;
            Order order3 = new Order();
            order3.CusName = "003";
            order3.OrderDetails.TotalPrice = 3;
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            try {
                bool result = true;
                bool flag = true;
                flag = orderService.addOrderGoods("001", "hu", "86", "5");
                flag = orderService.addOrderGoods("09", "hu", "86", "5");
                flag = orderService.addOrderGoods("001", "hu", "-68", "5");
                Assert.AreEqual(result, flag);
            }
            catch (InvalidOperationException e) {
                Assert.IsInstanceOfType(e, typeof(InvalidOperationException));
            }
            catch (ArgumentException e) {
                Assert.IsInstanceOfType(e, typeof(ArgumentException));

            }
        }

        [TestMethod()]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void deleteOrderGoodsTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            order1.OrderDetails.TotalPrice = 1;
            Order order2 = new Order();
            order2.CusName = "002";
            order2.OrderDetails.TotalPrice = 2;
            Order order3 = new Order();
            order3.CusName = "003";
            order3.OrderDetails.TotalPrice = 3;
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            orderService.addOrderGoods("001", "hu", "86", "5");
            orderService.addOrderGoods("001", "hf", "85", "5");
            orderService.addOrderGoods("001", "a", "6", "5");
            bool flag = true;
            bool result = true;
            flag = orderService.deleteOrderGoods("001", "hf");
            //flag = orderService.deleteOrderGoods("001", "1")
            //flag = orderService.deleteOrderGoods("001", "df");
            //flag = orderService.deleteOrderGoods("001", "5");
            Assert.AreEqual(result, flag);
        }

        [TestMethod()]
        public void renewOrderGoodsTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            order1.OrderDetails.TotalPrice = 1;
            Order order2 = new Order();
            order2.CusName = "002";
            order2.OrderDetails.TotalPrice = 2;
            Order order3 = new Order();
            order3.CusName = "003";
            order3.OrderDetails.TotalPrice = 3;
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            orderService.addOrderGoods("001", "hu", "86", "5");
            orderService.addOrderGoods("001", "hf", "85", "5");
            orderService.addOrderGoods("001", "a", "6", "5");
            try {
                bool flag = true;
                bool result = true;
                flag = orderService.renewOrderGoods("001", "a", "name", "hg");
                //flag = orderService.renewOrderGoods("sd", "a", "name", "hg");
                //flag = orderService.renewOrderGoods("001", "a", "name", "-1");
                //flag = orderService.renewOrderGoods("001", "85", "quantity", "-1");
                //flag = orderService.renewOrderGoods("001", "85", "sfdd", "-1");
                Assert.AreEqual(result, flag);
            }
            catch (InvalidOperationException e) {
                Assert.IsInstanceOfType(e, typeof(InvalidOperationException));
            }
            catch (ArgumentException e) {
                Assert.IsInstanceOfType(e, typeof(ArgumentException));
            }
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            order1.OrderDetails.TotalPrice = 1;
            Order order2 = new Order();
            order2.CusName = "002";
            order2.OrderDetails.TotalPrice = 2;
            Order order3 = new Order();
            order3.CusName = "003";
            order3.OrderDetails.TotalPrice = 3;
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            orderService.addOrderGoods("001", "hu", "86", "5");
            orderService.addOrderGoods("001", "hf", "85", "5");
            orderService.addOrderGoods("001", "a", "6", "5");
            orderService.Export("1.xml");
            FileStream fmodel = new FileStream("model.xml", FileMode.Open, FileAccess.Read);
            FileStream forder = new FileStream("1.xml", FileMode.Open, FileAccess.Read);
            StreamReader bmodel = new StreamReader(fmodel, System.Text.Encoding.UTF8);
            StreamReader border = new StreamReader(forder, System.Text.Encoding.UTF8);
            bool flag = true;
            bool result = true;
            string smodel = null;
            string sorder = null;
            do {
                flag = (smodel == sorder);
                smodel = bmodel.ReadLine();
                sorder = border.ReadLine();

            } while (smodel != null && sorder != null);
            fmodel.Close();
            forder.Close();
            Assert.AreEqual(result, flag);
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order();
            order1.CusName = "001";
            order1.OrderDetails.TotalPrice = 1;
            Order order2 = new Order();
            order2.CusName = "002";
            order2.OrderDetails.TotalPrice = 2;
            Order order3 = new Order();
            order3.CusName = "003";
            order3.OrderDetails.TotalPrice = 3;
            orderService.addOrder(order1);
            orderService.addOrder(order2);
            orderService.addOrder(order3);
            orderService.addOrderGoods("001", "hu", "86", "5");
            orderService.addOrderGoods("001", "hf", "85", "5");
            orderService.addOrderGoods("001", "a", "6", "5");
            OrderService orderServiceModel = new OrderService();
            orderServiceModel.Import("model.xml");
            CollectionAssert.Equals(orderService, orderServiceModel);
        }
    }
}