using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAboutOrder
{
    [Serializable]
    public class Order
    {
        private string customerName;
        private string orderNum;
        private string phoneNum;
        private OrderDetails orderDetails;

        public Order()
        {
            customerName = null;
            orderNum = null;
            orderDetails = new OrderDetails();
        }
        [Key]
        public string ID
        {
            get {
                return orderNum;
            }
            set {
                if (value != null) {
                    orderNum = value;
                } else {
                    throw new ArgumentException("Invalid order number");
                }
            }
        }
        public string CustomerName
        {
            get {
                return customerName;
            }
            set {
                if (value != null) {
                    customerName = value;
                } else {
                    throw new ArgumentException("Invalid customer Name");
                }
            }
        }
       public string PhoneNum
        {
            get {
                return phoneNum;
            }
            set {
                if (long.TryParse(value, out long pNum) && value.Length == 11) {
                    phoneNum = value;
                } else {
                throw new ArgumentException("Invalid Phone number");
            }
        }
        }
        public OrderDetails OrderDetails {
            get {
                return orderDetails;
            }
            set {
            }
        }

        public List<Good> Goods
        {
            get {
                return OrderDetails.OrderThings;
            }
            set { }
        }

        public double GoodsTotalPrice
        {
            get {
                return this.OrderDetails.TotalPrice;
            }
        }
        public override string ToString()
        {
            return $"Customer Name is {customerName}.\nThe order Number: {orderNum}.\n{OrderDetails.ToString()}";
        }
    }
}
