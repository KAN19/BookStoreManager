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
using System.Linq.Expressions;

namespace BookStoreManage.Container
{
    public partial class InvoiceView : UserControl
    {
        public event CloseFormHandler CloseForm;
        public event ChangeImageToNoneHandler ChangeImageToNone;
        public event SaveBillHandler SaveBill; 

        DataTable invoice = new DataTable();
        public InvoiceView()
        {
            InitializeComponent();

            invoice.Columns.Add("Tên sách", typeof(string));
            invoice.Columns.Add("Số lượng", typeof(int));
            invoice.Columns.Add("Đơn giá", typeof(int));
            invoice.Columns.Add("Thành tiền", typeof(int));
            dataGridView1_Bill.DataSource = invoice;


        }

        public int UpdateThanhTien()
        {
            int sum = 0;
            for (int index = 0; index < invoice.Rows.Count; index++)
            {
                sum += (int)invoice.Rows[index]["Thành tiền"];
            }
            textBox1_ThanhTien.Text = sum + "";

            return sum; 
        }

        public void AddBook(TypeOfBooks book)
        {
            for (int index = 0; index < invoice.Rows.Count; index++)
            {
                if (((string)invoice.Rows[index]["Tên sách"]) == book.Name)
                {
                    invoice.Rows[index]["Số lượng"] = ((int)invoice.Rows[index]["Số lượng"]) + 1;
                    invoice.Rows[index]["Thành tiền"] = ((int)invoice.Rows[index]["Đơn giá"]) * ((int)invoice.Rows[index]["Số lượng"]);
                    UpdateThanhTien();
                    return;
                }


            }
            invoice.Rows.Add(book.Name, 1, book.Price, book.Price);
            UpdateThanhTien();
        }

        private void dataGridView1_Bill_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;

            invoice.Rows[selectedRowIndex]["Thành tiền"] = ((int)invoice.Rows[selectedRowIndex]["Đơn giá"]) * ((int)invoice.Rows[selectedRowIndex]["Số lượng"]);
            UpdateThanhTien();

        }

        private void label3_TongCong_Click(object sender, EventArgs e)
        {
            int ThanhTien = 0;
            _ = Int32.TryParse(textBox1_ThanhTien.Text, out ThanhTien);
            double discount = 0;
            double.TryParse(textBox3_Discount.Text, out discount);
            textBox2_Total.Text = (ThanhTien - ThanhTien * (discount/100)).ToString();
        }

        private void textBox2_Total_Click(object sender, EventArgs e)
        {
            label3_TongCong_Click(null, null); 
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            dataGridView1_Bill.Columns[0].Width = 180; 
        }

        private void button_DeleteAll_Click(object sender, EventArgs e)
        {
            invoice.Clear();
            ChangeImageToNone();
            textBox1_ThanhTien.Clear();
            textBox3_Discount.Clear();
            textBox2_Total.Clear(); 
        }

        private void button_PrintBill_Click(object sender, EventArgs e)
        {
            int thanhtien = UpdateThanhTien();
            label3_TongCong_Click(null, null); 
            double discount = 0; 
            double.TryParse(textBox3_Discount.Text, out discount); 

            SaveBill(invoice, thanhtien, discount); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForm(); 
        }
    }
}
