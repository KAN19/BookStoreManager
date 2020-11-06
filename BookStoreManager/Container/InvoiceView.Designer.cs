namespace BookStoreManage.Container
{
    partial class InvoiceView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1_Bill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3_TongCong = new System.Windows.Forms.Label();
            this.textBox1_ThanhTien = new System.Windows.Forms.TextBox();
            this.textBox2_Total = new System.Windows.Forms.TextBox();
            this.textBox3_Discount = new System.Windows.Forms.TextBox();
            this.button_DeleteAll = new System.Windows.Forms.Button();
            this.button_PrintBill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Bill
            // 
            this.dataGridView1_Bill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1_Bill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Bill.Location = new System.Drawing.Point(2, 10);
            this.dataGridView1_Bill.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1_Bill.Name = "dataGridView1_Bill";
            this.dataGridView1_Bill.RowHeadersWidth = 51;
            this.dataGridView1_Bill.RowTemplate.Height = 24;
            this.dataGridView1_Bill.Size = new System.Drawing.Size(476, 292);
            this.dataGridView1_Bill.TabIndex = 0;
            this.dataGridView1_Bill.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_Bill_CellEndEdit);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 316);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiền sách:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 346);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giảm giá: %";
            // 
            // label3_TongCong
            // 
            this.label3_TongCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3_TongCong.AutoSize = true;
            this.label3_TongCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_TongCong.Location = new System.Drawing.Point(14, 376);
            this.label3_TongCong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3_TongCong.Name = "label3_TongCong";
            this.label3_TongCong.Size = new System.Drawing.Size(93, 20);
            this.label3_TongCong.TabIndex = 8;
            this.label3_TongCong.Text = "Tổng cộng";
            this.label3_TongCong.Click += new System.EventHandler(this.label3_TongCong_Click);
            // 
            // textBox1_ThanhTien
            // 
            this.textBox1_ThanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_ThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_ThanhTien.Location = new System.Drawing.Point(134, 312);
            this.textBox1_ThanhTien.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1_ThanhTien.Name = "textBox1_ThanhTien";
            this.textBox1_ThanhTien.Size = new System.Drawing.Size(318, 22);
            this.textBox1_ThanhTien.TabIndex = 9;
            // 
            // textBox2_Total
            // 
            this.textBox2_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_Total.Location = new System.Drawing.Point(134, 376);
            this.textBox2_Total.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2_Total.Name = "textBox2_Total";
            this.textBox2_Total.Size = new System.Drawing.Size(318, 22);
            this.textBox2_Total.TabIndex = 10;
            this.textBox2_Total.Click += new System.EventHandler(this.textBox2_Total_Click);
            // 
            // textBox3_Discount
            // 
            this.textBox3_Discount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3_Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_Discount.Location = new System.Drawing.Point(134, 344);
            this.textBox3_Discount.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3_Discount.Name = "textBox3_Discount";
            this.textBox3_Discount.Size = new System.Drawing.Size(318, 22);
            this.textBox3_Discount.TabIndex = 11;
            // 
            // button_DeleteAll
            // 
            this.button_DeleteAll.BackColor = System.Drawing.Color.Green;
            this.button_DeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteAll.ForeColor = System.Drawing.Color.White;
            this.button_DeleteAll.Location = new System.Drawing.Point(140, 417);
            this.button_DeleteAll.Name = "button_DeleteAll";
            this.button_DeleteAll.Size = new System.Drawing.Size(90, 35);
            this.button_DeleteAll.TabIndex = 12;
            this.button_DeleteAll.Text = "Xóa tất cả";
            this.button_DeleteAll.UseVisualStyleBackColor = false;
            this.button_DeleteAll.Click += new System.EventHandler(this.button_DeleteAll_Click);
            // 
            // button_PrintBill
            // 
            this.button_PrintBill.BackColor = System.Drawing.Color.Green;
            this.button_PrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PrintBill.ForeColor = System.Drawing.Color.White;
            this.button_PrintBill.Location = new System.Drawing.Point(239, 417);
            this.button_PrintBill.Name = "button_PrintBill";
            this.button_PrintBill.Size = new System.Drawing.Size(113, 35);
            this.button_PrintBill.TabIndex = 12;
            this.button_PrintBill.Text = "Xuất hoát đơn";
            this.button_PrintBill.UseVisualStyleBackColor = false;
            this.button_PrintBill.Click += new System.EventHandler(this.button_PrintBill_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(362, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_PrintBill);
            this.Controls.Add(this.button_DeleteAll);
            this.Controls.Add(this.textBox3_Discount);
            this.Controls.Add(this.textBox2_Total);
            this.Controls.Add(this.textBox1_ThanhTien);
            this.Controls.Add(this.label3_TongCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1_Bill);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InvoiceView";
            this.Size = new System.Drawing.Size(480, 470);
            this.Load += new System.EventHandler(this.InvoiceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Bill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1_Bill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3_TongCong;
        private System.Windows.Forms.TextBox textBox1_ThanhTien;
        private System.Windows.Forms.TextBox textBox2_Total;
        private System.Windows.Forms.TextBox textBox3_Discount;
        private System.Windows.Forms.Button button_DeleteAll;
        private System.Windows.Forms.Button button_PrintBill;
        private System.Windows.Forms.Button button1;
    }
}
