using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeManager.Utilities;

namespace CoffeeManager.Container.Menu
{
    public partial class MenuHongTra : UserControl
    {
        List<CDrink> hongtra_list = DrinksData.GetMenuHongTra();

        public event clickToOrderHandler orderHongTra;
        public MenuHongTra()
        {
            InitializeComponent();
            foreach (var item in hongtra_list)
            {
                MyDrinkButton myBtn = new MyDrinkButton(item);
                myBtn.Click += MyBtn_Click;
                flowLayoutPanel1_menu.Controls.Add(myBtn);
            }
            
        }

        private void MyBtn_Click(object sender, EventArgs e)
        {
            CDrink selectedDrink = ((MyDrinkButton)sender).MyDrink;
            orderHongTra(selectedDrink);
        }
    }
}
