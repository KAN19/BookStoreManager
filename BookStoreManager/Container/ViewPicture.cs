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
using BookStoreManage.Container;

namespace BookStoreMange.Container.Menu
{
    public partial class ViewPicture : UserControl
    {
        InvoiceView invoice = new InvoiceView();
        public ViewPicture()
        {
            InitializeComponent();

            invoice.ChangeImageToNone += Invoice_ChangeImageToNone;
        }

        private void Invoice_ChangeImageToNone()
        {
            pictureBox_AnhSach.Image = null;
        }


        public void AddImage(TypeOfBooks book)
        {
            pictureBox_AnhSach.Image = book.myImage; 
        }
    }
}
