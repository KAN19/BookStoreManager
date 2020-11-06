using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManage.Utilities
{
    class BookButton : Button
    {
        TypeOfBooks myBook;

        public BookButton(TypeOfBooks myBook)
        {
            this.myBook = myBook;
            this.Text = myBook.Name;
            //this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.Size = new System.Drawing.Size(110, 70);
        }

        public TypeOfBooks MyBook { get => myBook; set => myBook = value; }
    }
}
