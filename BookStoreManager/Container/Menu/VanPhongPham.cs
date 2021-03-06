﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreManage.Utilities;

namespace BookStoreManage.Container.Menu
{
    public partial class VanPhongPham : UserControl
    {
        List<TypeOfBooks> listBook = BookDetails.GetVanPhongPham();

        public event clickToAddStockHandler Add;
        public VanPhongPham()
        {
            InitializeComponent();
            foreach (var item in listBook)
            {
                BookButton myBtn = new BookButton(item);
                myBtn.Click += MyBtn_Click;
                flowLayoutPanel1_list.Controls.Add(myBtn);
            }

        }

        private void MyBtn_Click(object sender, EventArgs e)
        {
            TypeOfBooks selectedBook = ((BookButton)sender).MyBook;
            Add(selectedBook);
        }
    }
}
