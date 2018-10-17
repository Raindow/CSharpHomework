using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
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
                    throw new ArgumentException("Invalid input");
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
                    throw new ArgumentException("Invalid input");
                }
            }
        }

        public OrderDetails OrderDetails
        {
            get {
                return orderDetails;
            }
        }
        public List<Good> Goods
        {
            get {
                return orderDetails.OrderThings;
            }
        }

        public override string ToString()
        {
            return $"Customer Name is {customerName}.\nThe order Number: {orderNum}.\n{orderDetails.ToString()}";
        }
    }
}
