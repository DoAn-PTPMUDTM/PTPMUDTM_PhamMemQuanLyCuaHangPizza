using BLL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class FrmMnOrder : Form
    {
        public FrmMnOrder()
        {
            InitializeComponent();
        }

        private void frmMnOrder_Load(object sender, EventArgs e)
        {
            dgvOrder.DataSource = OrderBLL.Instance.GetAll().Select(item => new
            {
                item.order_id,
                item.full_name,
                item.phone_number,
                item.shipping_address,
                item.total_price,
                item.status,
                item.created_at
            });
        }
    }
}
