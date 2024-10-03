namespace Project
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mànHìnhChứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemNguoiDungVaoNhomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hTToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hTToolStripMenuItem
            // 
            this.hTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NguoiDungToolStripMenuItem,
            this.nhómNgườiDùngToolStripMenuItem,
            this.mànHìnhChứcNăngToolStripMenuItem,
            this.ThemNguoiDungVaoNhomToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem});
            this.hTToolStripMenuItem.Name = "hTToolStripMenuItem";
            this.hTToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.hTToolStripMenuItem.Text = "Hệ Thống";
            // 
            // NguoiDungToolStripMenuItem
            // 
            this.NguoiDungToolStripMenuItem.Name = "NguoiDungToolStripMenuItem";
            this.NguoiDungToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.NguoiDungToolStripMenuItem.Text = "Người dùng";
            this.NguoiDungToolStripMenuItem.Click += new System.EventHandler(this.NguoiDungToolStripMenuItem_Click);
            // 
            // nhómNgườiDùngToolStripMenuItem
            // 
            this.nhómNgườiDùngToolStripMenuItem.Name = "nhómNgườiDùngToolStripMenuItem";
            this.nhómNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.nhómNgườiDùngToolStripMenuItem.Text = "Nhóm người dùng";
            // 
            // mànHìnhChứcNăngToolStripMenuItem
            // 
            this.mànHìnhChứcNăngToolStripMenuItem.Name = "mànHìnhChứcNăngToolStripMenuItem";
            this.mànHìnhChứcNăngToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.mànHìnhChứcNăngToolStripMenuItem.Text = "Màn hình chức năng";
            // 
            // ThemNguoiDungVaoNhomToolStripMenuItem
            // 
            this.ThemNguoiDungVaoNhomToolStripMenuItem.Name = "ThemNguoiDungVaoNhomToolStripMenuItem";
            this.ThemNguoiDungVaoNhomToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.ThemNguoiDungVaoNhomToolStripMenuItem.Text = "Thêm người dùng vào nhóm";
            this.ThemNguoiDungVaoNhomToolStripMenuItem.Click += new System.EventHandler(this.ThemNguoiDungVaoNhomToolStripMenuItem_Click);
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp Vụ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 519);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mànHìnhChứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThemNguoiDungVaoNhomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
    }
}