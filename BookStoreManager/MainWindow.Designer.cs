using System.Windows.Forms;

namespace BookStoreManage
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_invoice = new System.Windows.Forms.Panel();
            this.panel_ListBooks = new System.Windows.Forms.Panel();
            this.panel_typeOfBooks = new System.Windows.Forms.Panel();
            this.panel_Picture = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // panel_invoice
            // 
            this.panel_invoice.BackColor = System.Drawing.Color.White;
            this.panel_invoice.Location = new System.Drawing.Point(393, 0);
            this.panel_invoice.Margin = new System.Windows.Forms.Padding(2);
            this.panel_invoice.Name = "panel_invoice";
            this.panel_invoice.Size = new System.Drawing.Size(485, 478);
            this.panel_invoice.TabIndex = 0;
            // 
            // panel_ListBooks
            // 
            this.panel_ListBooks.AutoScroll = true;
            this.panel_ListBooks.BackColor = System.Drawing.Color.Azure;
            this.panel_ListBooks.Location = new System.Drawing.Point(140, 0);
            this.panel_ListBooks.Margin = new System.Windows.Forms.Padding(2);
            this.panel_ListBooks.Name = "panel_ListBooks";
            this.panel_ListBooks.Size = new System.Drawing.Size(249, 279);
            this.panel_ListBooks.TabIndex = 0;
            // 
            // panel_typeOfBooks
            // 
            this.panel_typeOfBooks.BackColor = System.Drawing.Color.White;
            this.panel_typeOfBooks.Location = new System.Drawing.Point(0, 0);
            this.panel_typeOfBooks.Margin = new System.Windows.Forms.Padding(2);
            this.panel_typeOfBooks.Name = "panel_typeOfBooks";
            this.panel_typeOfBooks.Size = new System.Drawing.Size(136, 482);
            this.panel_typeOfBooks.TabIndex = 0;
            // 
            // panel_Picture
            // 
            this.panel_Picture.BackColor = System.Drawing.Color.Azure;
            this.panel_Picture.Location = new System.Drawing.Point(140, 284);
            this.panel_Picture.Name = "panel_Picture";
            this.panel_Picture.Size = new System.Drawing.Size(248, 194);
            this.panel_Picture.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 482);
            this.Controls.Add(this.panel_Picture);
            this.Controls.Add(this.panel_typeOfBooks);
            this.Controls.Add(this.panel_ListBooks);
            this.Controls.Add(this.panel_invoice);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Cửa hàng sách NguyenKiet";
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_invoice;
        private Panel panel_ListBooks;
        private Panel panel_typeOfBooks;
        private Panel panel_Picture;
        private SaveFileDialog saveFileDialog1;
    }
}

