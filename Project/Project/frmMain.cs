using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.FormClosed += frmMain_FormClosed;
        }

        void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.loginForm.Show();
        }

        

        private void ThemNguoiDungVaoNhomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemNguoiDungVaoNhom frm = new frmThemNguoiDungVaoNhom();
            frm.MdiParent = this;
            frm.Show();
        }

        private void NguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNguoidung frm = new frmNguoidung();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
