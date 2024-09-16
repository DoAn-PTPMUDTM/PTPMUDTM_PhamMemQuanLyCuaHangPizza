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
    }
}
