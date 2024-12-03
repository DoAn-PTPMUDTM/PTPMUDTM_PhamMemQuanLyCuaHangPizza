using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectWin
{
    public partial class frmComment : Form
    {
        private List<comment> _comments = new List<comment>();
        public frmComment()
        {
            InitializeComponent();
        }

        private void ResetTextBox()
        {
            txtId.ResetText();
            txtUser.ResetText();
            txtContent.ResetText();
        }

        private void ToggleTextbox(bool state)
        {
            txtUser.Enabled = state;
            txtContent.Enabled = state;
        }


        private void LoadData()
        {
            _comments = CommentBll.instance.FindAll();

            dgv.DataSource = _comments
                .Select(item => new
                {
                    item.comment_id,
                    item.user?.email,
                    item.product?.product_name,
                    item.content,
                    item.comment_date
                })
                .ToList();
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Text = _comments[e.RowIndex].comment_id.ToString();
            txtUser.Text = _comments[e.RowIndex]?.user.email;
            txtProduct.Text = _comments[e.RowIndex]?.product.product_name;
            txtDate.Text = _comments[e.RowIndex]?.comment_date.ToString();
            txtContent.Text = _comments[e.RowIndex]?.content;

            btnDel.Enabled = true;
        }

        private void frmMnTable_Load(object sender, EventArgs e)
        {
            btnReload_Click(sender, e);
            dgv.Columns[0].HeaderText = @"Mã bình luận";
            dgv.Columns[1].HeaderText = @"Người bình luận";
            dgv.Columns[2].HeaderText = @"Sản phẩm";
            dgv.Columns[3].HeaderText = @"Nội dung";
            dgv.Columns[4].HeaderText = @"Ngày bình luận";
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            ToggleTextbox(false);
            LoadData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show(@"Vui lòng chọn bình luận xóa");
                return;
            }

            if (MessageBox.Show(@"Bạn chắc chắn muốn xóa bình luận này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var result = CommentBll.instance.Remove(txtId.Text.Trim());
                    MessageBox.Show(result.data.ToString());
                    if(result.isSuccess)
                    {
                        btnReload_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Lỗi: {ex.Message}");
                }
            }
        }
    }
}
