using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    [Serializable]
    public class Good
    {
        private uint id;
        private string name;
        private uint quantity;
        private double uPrice;
        private double tPrice;
        public Good()
        {
            id = 0;
            name = null;
            quantity = 0;
            uPrice = 0;
            tPrice = 0;
        }
        public Good(string name, uint quantity, double uPrice)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.UPrice = uPrice;
            this.TPrice = uPrice * quantity;
        }
        public string Name
        {
            get {
                return name;
            }
            set {
                if (value != null) {
                    this.name = value;
                } else {
                    throw new ArgumentNullException("Invalid name");
                }
            }
        }

        public uint Id
        {
            get {
                return id;
            }
            set {
                if (value > 0) {
                    this.id = value;
                } else {
                    throw new ArgumentException("Invalid id");
                }
            }
        }

        public uint Quantity
        {
            get {
                return quantity;
            }
            set {
                if (value > 0) {
                    this.quantity = value;
                } else {
                    throw new ArgumentException("Invalid quantity");
                }
            }
        }

        public double UPrice
        {
            get {
                return uPrice;
            }
            set {
                if (value > 0) {
                    this.uPrice = value;
                } else {
                    throw new ArgumentException("Invalid uPrice");
                }
            }
        }

        public double TPrice {
            get => tPrice; set => tPrice = value;
        }


        public override string ToString()
        {
            return $"id: {Id}, name: {Name}, quantity: {Quantity}, unit price: {UPrice}, total price {TPrice}.";
        }
       
    }
}
