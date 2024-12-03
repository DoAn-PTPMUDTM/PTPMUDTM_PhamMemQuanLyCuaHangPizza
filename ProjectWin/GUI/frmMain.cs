using DTO;
using System;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class FrmMain : Form
    {
        private readonly User _u;

        public FrmMain(User user)
        {
            InitializeComponent();
            this._u = user;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReInitComponent()
        {
            if (Constant.Staff.Equals(_u?.role))
            {
                btnDashboard.Visible = false;
                btnAccount.Visible = false;
            }
            OpenForm(new FrmProduct());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ReInitComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmMnStaff());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDashboard());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmCategory());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmProduct());
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            OpenForm(new frmComment());
        }

        private void OpenForm(Form frm)
        {
            pnContent.Controls.Clear();
            frm.TopLevel = false;
            pnContent.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}