using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManage
{
    class Product
    {
        private string name;
        private int amount;
        private int price;
        private int total;

        public Product(string name, int amount, int price, int total)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;
            this.total = total;
        }

        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Price { get => price; set => price = value; }
        //public int Total { get => total; set =>  total = value;  }

        public int Total()
        {
            return price * amount;
        }
    }
}
