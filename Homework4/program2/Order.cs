using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Order
    {
        private string customerName;
        private string orderNum;
        private OrderDetails orderDetails = new OrderDetails();
        public string CusName
        {
            get {
                return customerName;
            }
            set {
                if (value != null) {
                    customerName = value;
                } else {
                    throw new Exception("Invalid input");
                }
            }
        }
        public string OrderNum
        {
            get {
                return orderNum;
            }
            set {
                if(value != null) {
                    orderNum = value;
                } else {
                    throw new Exception("Invalid input");
                }

            }
        }
        public string Thing
        {
            get {
                return orderDetails.orderThings;
            }
            set {
                if (value != null) {
                    orderDetails.orderThings = value;
                } else {
                    throw new Exception("Invalid input");
                }
            }
        }
    }
}
