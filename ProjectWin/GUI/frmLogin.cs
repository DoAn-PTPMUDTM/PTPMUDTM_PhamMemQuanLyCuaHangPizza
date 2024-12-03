using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Bạn có chắc muốn thoát?", @"Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();
            var result = LoginBll.instance.DoLogin(username, password);
            if (result.isSuccess)
            {
                var user = result.data as User;
                this.Hide();
                new FrmMain(user).ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show(result.data.ToString());
            }
        }
    }
}