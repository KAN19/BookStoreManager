using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManage.Utilities
{
    public class TypeOfBooks

    {
        protected string id;
        protected string name;
        protected int price;
        protected Bitmap _myImage; 

        public TypeOfBooks(string id, string name, int price, Bitmap bitmap)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this._myImage = bitmap; 
        }

        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public Bitmap myImage { get => _myImage; set => _myImage = value; }
    }
}
