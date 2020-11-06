namespace BookStoreMange.Container.Menu
{
    partial class ViewPicture
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
            this.pictureBox_AnhSach = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AnhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_AnhSach
            // 
            this.pictureBox_AnhSach.Location = new System.Drawing.Point(22, 16);
            this.pictureBox_AnhSach.Name = "pictureBox_AnhSach";
            this.pictureBox_AnhSach.Size = new System.Drawing.Size(205, 140);
            this.pictureBox_AnhSach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_AnhSach.TabIndex = 0;
            this.pictureBox_AnhSach.TabStop = false;
            // 
            // ViewPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox_AnhSach);
            this.Name = "ViewPicture";
            this.Size = new System.Drawing.Size(248, 176);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_AnhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_AnhSach;
    }
}
