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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            UserControl1.ChuoiCauhinh = Properties.Settings.Default.CONN;
            UserControl1.GetChangeKQ += UserControl1_GetChangeKQ;
        }

        void UserControl1_GetChangeKQ(object sender, EventArgs e)
        {
            if(UserControl1.TT == true)
            {
                if (Program.mainForm == null || Program.mainForm.IsDisposed)
                {
                    Program.mainForm = new frmMain();
                }
                this.Visible = false;
                Program.mainForm.Show();
            }
        }
    }
}
