using BookStoreManage.Container;
using BookStoreManage.Container.Menu;
using BookStoreManage.Utilities;
using BookStoreMange.Container.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManage
{
    public partial class MainWindow : Form
    {
        InvoiceView invoice_view = new InvoiceView();
        TypeOfBooksView viewTypeOfBooks = new TypeOfBooksView();

        TieuThuyet viewTieuThuyet = new TieuThuyet();
        SelfHelp viewSelfHelp = new SelfHelp();
        KinhDoanh viewKinhDoanh = new KinhDoanh();
        TruyenTranh viewTruyenTranh = new TruyenTranh();
        VanPhongPham viewVanPhongPham = new VanPhongPham();

        ViewPicture viewPicture = new ViewPicture();

        

        public MainWindow()
        {
            InitializeComponent();

            invoice_view.Dock = DockStyle.Fill;
            panel_invoice.Controls.Add(invoice_view);

            panel_ListBooks.AutoScroll = true; 

            viewTypeOfBooks.Dock = DockStyle.Fill;
            viewTypeOfBooks.SwitchView += switchViewTypeOfBook;
            panel_typeOfBooks.Controls.Add(viewTypeOfBooks);

            panel_Picture.Controls.Add(viewPicture);

            viewSelfHelp.AddSelfHelpBook += AddToStocks;
            panel_ListBooks.Controls.Add(viewSelfHelp);

            viewTieuThuyet.AddBook += AddToStocks;
            panel_ListBooks.Controls.Add(viewTieuThuyet);

            viewKinhDoanh.AddBook += AddToStocks;
            panel_ListBooks.Controls.Add(viewKinhDoanh);

            viewTruyenTranh.Add += AddToStocks;
            panel_ListBooks.Controls.Add(viewTruyenTranh);

            viewVanPhongPham.Add += AddToStocks;
            panel_ListBooks.Controls.Add(viewVanPhongPham);

            //Change image to none when clear all 
            invoice_view.ChangeImageToNone += Invoice_view_ChangeImageToNone;

            //Close form
            invoice_view.CloseForm += CloseForm;

            //Print Bill 
            invoice_view.SaveBill += Invoice_view_SaveBill1;
        }

        private void switchViewTypeOfBook(int id)
        {
            switch (id)
            {
                case 5:
                    panel_ListBooks.Controls["VanPhongPham"].BringToFront();
                    break;
                case 4:
                    panel_ListBooks.Controls["TruyenTranh"].BringToFront();
                    break;
                case 3:
                    panel_ListBooks.Controls["KinhDoanh"].BringToFront();
                    break;
                case 2:
                    panel_ListBooks.Controls["TieuThuyet"].BringToFront();
                    break;
                case 1:
                    panel_ListBooks.Controls["SelfHelp"].BringToFront();
                    break;
                default:
                    break;
            }
        }

        private void AddToStocks(Utilities.TypeOfBooks book)
        {
            invoice_view.AddBook(book);
            viewPicture.AddImage(book); 
        }

        private void CloseForm()
        {
            this.Close(); 
        }


        private void Invoice_view_ChangeImageToNone()
        {
            viewPicture.AddImage(new TypeOfBooks("", "", 1, null));
        }


        private void Invoice_view_SaveBill1(DataTable table, int sum, double discount)
        {
            saveFileDialog1.Filter = "Text File|*.txt";
            saveFileDialog1.Title = "Save bill to a Text File";

            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog1.FileName))
                {
                    sw.WriteLine("HÓA ĐƠN NHÀ SÁCH NGUYENKIET\n"); 
                    sw.WriteLine("Số hóa đơn: 00010"); 
                    sw.WriteLine("Ngày mua hàng: {0}", DateTime.Now.ToString());
                    sw.WriteLine("STT \t Sản phẩm \t Số lương \t Đơn giá \t Thành tiền");
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        sw.WriteLine("{0} \t {1} \t {2} \t {3} \t {4}",
                            i + 1,
                            table.Rows[i]["Tên sách"].ToString(),
                            table.Rows[i]["Số lượng"],
                            table.Rows[i]["Đơn giá"],
                            table.Rows[i]["Thành tiền"]);
                    }

                    sw.WriteLine("\nTỔNG CỘNG: {0}", sum);
                    sw.WriteLine("GIẢM GIÁ : {0}%", discount);
                    sw.WriteLine("THÀNH TIỀN: {0}", sum * ((100 - discount) / 100)); 
                }

                MessageBox.Show("Lưu hóa đơn thành công!", "Lưu hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                
            }
           

        }



    }
}
