using BLL;
using DTO;
using System;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            var result = DashboardBll.Instance.Get();
            txtRevenue.Texts = string.Format("{0:N0} VNĐ", result[Constant.Revenue]);
            txtRevenueToday.Texts = string.Format("{0:N0} VNĐ", result[Constant.RevenueToday]);

            txtStaff.Texts = string.Format("{0}", result[Constant.TotalStaff]);
            txtCus.Texts = string.Format("{0}", result[Constant.TotalCus]);
            txtProduct.Texts = string.Format("{0}", result[Constant.TotalProduct]);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNumProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
