using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    [Serializable]
    public class OrderDetails
    {
        private List<Good> orderThings;
        private double totalPrice;

        public OrderDetails()
        {
            orderThings = new List<Good>();
            totalPrice = 0;

        }
        public List<Good> OrderThings
        {
            get {
                return orderThings;
            }
        }

        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public bool addGoods(string name, uint quantity, double uPrice)
        {
            Good nGoods = new Good(name, quantity, uPrice);

            if (orderThings.Count == 0 || (orderThings.Where(good => good.Name == name).Count()) == 0){
                nGoods.Id = (uint)orderThings.Count + 1;
                orderThings.Add(nGoods);
                this.TotalPrice += nGoods.TPrice;
                return true;
            } else {
                throw new ArgumentException("Already has that good");
            }

        }

        public Good seekGood(string according)
        {
            if(uint.TryParse(according, out uint id)) {
                return orderThings.Where(good => good.Id == id).First<Good>();
            } else {
                return orderThings.Where(good => good.Name == according).First<Good>();
            }
           //错误处理
        }

        public bool deleteGoods(string according) {

            Good sGood = seekGood(according);
            this.TotalPrice -= sGood.TPrice;
            orderThings.Remove(sGood);
            uint i = 1;
            orderThings.ForEach(good => {
                good.Id = i;
                i++;
            });
            return true;
        }

        public bool renewGood(string according, string item, string newDate)
        {
            Good good = seekGood(according);
            switch (item.ToLower()) {
                case "name":
                    good.Name = newDate;
                    break;
                case "quantity":
                    if(uint.TryParse(newDate, out uint quantity)) {
                        good.Quantity = quantity;
                    }
                    throw new ArgumentException("Invalid quantity");
                case "uprice":
                    if (double.TryParse(newDate, out double uPrice)) {
                        good.UPrice = uPrice;
                    }
                    throw new ArgumentException("Invalid unit price");
                default:
                    throw new ArgumentException("you can't change that item or invalid item");
            }
            this.TotalPrice -= good.TPrice;
            good.TPrice = good.Quantity * good.UPrice;
            this.TotalPrice += good.TPrice;
            return true;
        }
        public override string ToString()
        {
            StringBuilder thingList = new StringBuilder();
            orderThings.ForEach((Good good) => {
                thingList.Append(good.ToString() + "\n");
            });
            return thingList.ToString();
        }
    }
}
