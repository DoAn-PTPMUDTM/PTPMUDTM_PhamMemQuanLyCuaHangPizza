namespace Project
{
    partial class LoginForm
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
            this.UserControl1 = new MD_DangNhap.UserControl1();
            this.SuspendLayout();
            // 
            // UserControl1
            // 
            this.UserControl1.ChuoiCauhinh = null;
            this.UserControl1.Location = new System.Drawing.Point(25, 12);
            this.UserControl1.Name = "UserControl1";
            this.UserControl1.Size = new System.Drawing.Size(473, 270);
            this.UserControl1.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 305);
            this.Controls.Add(this.UserControl1);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MD_DangNhap.UserControl1 UserControl1;
    }
}

