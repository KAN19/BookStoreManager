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

namespace BookStoreManage.Container
{
    public partial class TypeOfBooksView : UserControl
    {
        public event SwitchViewHandler SwitchView;
        public TypeOfBooksView()
        {
            InitializeComponent();
        }

        private void button1_SelfHelp_Click(object sender, EventArgs e)
        {
            SwitchView(1);
        }

        private void button2_TraSua_Click(object sender, EventArgs e)
        {
            SwitchView(2);
        }

        private void button3_Soda_Click(object sender, EventArgs e)
        {
            SwitchView(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SwitchView(4);
        }

        private void button5_Topping_Click(object sender, EventArgs e)
        {
            SwitchView(5);
        }

        
    }
}
