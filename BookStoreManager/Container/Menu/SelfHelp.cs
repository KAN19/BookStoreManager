using System;
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
    public partial class SelfHelp : UserControl
    {
        List<TypeOfBooks> SelfHelpList = BookDetails.GetSelfHelpBooks();

        public event clickToAddStockHandler AddSelfHelpBook;
        public SelfHelp()
        {
            InitializeComponent();
            foreach (var item in SelfHelpList)
            {
                BookButton myBtn = new BookButton(item);
                myBtn.Click += MyBtn_Click;
                flowLayoutPanel1_list.Controls.Add(myBtn);
            }
            
        }

        private void MyBtn_Click(object sender, EventArgs e)
        {
            TypeOfBooks selectedBook = ((BookButton)sender).MyBook;
            AddSelfHelpBook(selectedBook);
        }
    }
}
