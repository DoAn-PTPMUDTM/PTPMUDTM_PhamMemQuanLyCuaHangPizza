namespace ProjectWin
{
    partial class FrmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStaff = new ProjectWin.RJTextBox();
            this.txtCus = new ProjectWin.RJTextBox();
            this.txtProduct = new ProjectWin.RJTextBox();
            this.txtRevenue = new ProjectWin.RJTextBox();
            this.txtRevenueToday = new ProjectWin.RJTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.txtRevenueToday);
            this.groupBox1.Controls.Add(this.txtRevenue);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Controls.Add(this.txtCus);
            this.groupBox1.Controls.Add(this.txtStaff);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1177, 720);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 347);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1077, 361);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(528, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Doanh thu hôm nay:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doanh thu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số nhân viên:";
            // 
            // txtStaff
            // 
            this.txtStaff.BackColor = System.Drawing.SystemColors.Window;
            this.txtStaff.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtStaff.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtStaff.BorderRadius = 0;
            this.txtStaff.BorderSize = 2;
            this.txtStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStaff.Location = new System.Drawing.Point(256, 46);
            this.txtStaff.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaff.Multiline = false;
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStaff.PasswordChar = false;
            this.txtStaff.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtStaff.PlaceholderText = "";
            this.txtStaff.Size = new System.Drawing.Size(222, 39);
            this.txtStaff.TabIndex = 4;
            this.txtStaff.Texts = "";
            this.txtStaff.UnderlinedStyle = false;
            // 
            // txtCus
            // 
            this.txtCus.BackColor = System.Drawing.SystemColors.Window;
            this.txtCus.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCus.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCus.BorderRadius = 0;
            this.txtCus.BorderSize = 2;
            this.txtCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCus.Location = new System.Drawing.Point(256, 101);
            this.txtCus.Margin = new System.Windows.Forms.Padding(4);
            this.txtCus.Multiline = false;
            this.txtCus.Name = "txtCus";
            this.txtCus.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCus.PasswordChar = false;
            this.txtCus.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCus.PlaceholderText = "";
            this.txtCus.Size = new System.Drawing.Size(222, 39);
            this.txtCus.TabIndex = 5;
            this.txtCus.Texts = "";
            this.txtCus.UnderlinedStyle = false;
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.SystemColors.Window;
            this.txtProduct.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtProduct.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtProduct.BorderRadius = 0;
            this.txtProduct.BorderSize = 2;
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProduct.Location = new System.Drawing.Point(256, 148);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduct.Multiline = false;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtProduct.PasswordChar = false;
            this.txtProduct.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtProduct.PlaceholderText = "";
            this.txtProduct.Size = new System.Drawing.Size(222, 39);
            this.txtProduct.TabIndex = 5;
            this.txtProduct.Texts = "";
            this.txtProduct.UnderlinedStyle = false;
            // 
            // txtRevenue
            // 
            this.txtRevenue.BackColor = System.Drawing.SystemColors.Window;
            this.txtRevenue.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRevenue.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRevenue.BorderRadius = 0;
            this.txtRevenue.BorderSize = 2;
            this.txtRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRevenue.Location = new System.Drawing.Point(256, 226);
            this.txtRevenue.Margin = new System.Windows.Forms.Padding(4);
            this.txtRevenue.Multiline = false;
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRevenue.PasswordChar = false;
            this.txtRevenue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRevenue.PlaceholderText = "";
            this.txtRevenue.Size = new System.Drawing.Size(222, 39);
            this.txtRevenue.TabIndex = 5;
            this.txtRevenue.Texts = "";
            this.txtRevenue.UnderlinedStyle = false;
            // 
            // txtRevenueToday
            // 
            this.txtRevenueToday.BackColor = System.Drawing.SystemColors.Window;
            this.txtRevenueToday.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtRevenueToday.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtRevenueToday.BorderRadius = 0;
            this.txtRevenueToday.BorderSize = 2;
            this.txtRevenueToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenueToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRevenueToday.Location = new System.Drawing.Point(256, 291);
            this.txtRevenueToday.Margin = new System.Windows.Forms.Padding(4);
            this.txtRevenueToday.Multiline = false;
            this.txtRevenueToday.Name = "txtRevenueToday";
            this.txtRevenueToday.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRevenueToday.PasswordChar = false;
            this.txtRevenueToday.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtRevenueToday.PlaceholderText = "";
            this.txtRevenueToday.Size = new System.Drawing.Size(222, 39);
            this.txtRevenueToday.TabIndex = 5;
            this.txtRevenueToday.Texts = "";
            this.txtRevenueToday.UnderlinedStyle = false;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 720);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RJTextBox txtRevenueToday;
        private RJTextBox txtRevenue;
        private RJTextBox txtProduct;
        private RJTextBox txtCus;
        private RJTextBox txtStaff;
    }
}