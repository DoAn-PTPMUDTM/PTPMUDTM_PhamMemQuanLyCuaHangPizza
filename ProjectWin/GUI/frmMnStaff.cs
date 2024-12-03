using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProjectWin
{
    public partial class FrmMnStaff : Form
    {
        private List<User> _listAccount;

        public FrmMnStaff()
        {
            InitializeComponent();
        }

        private void ResetTextBox()
        {
            txtID.ResetText();
            txtFullName.ResetText();
            txtPassword.ResetText();
            txtUsername.ResetText();
        }

        private void ToggleTextbox(bool state)
        {
            txtFullName.Enabled = state;
            txtPassword.Enabled = state;
            txtUsername.Enabled = state;
            cboRole.Enabled = state;
        }

        private void DisableButton()
        {
            btnAdd.Enabled = true;

            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = false;
        }

        private void EnableButton()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            btnSave.Enabled = true;
        }

        private void LoadData()
        {
            _listAccount = AccountBll.instance.FindAll();

            dgvStaff.DataSource = _listAccount
                .Select(item => new
                {
                    item.user_id,
                    item.email,
                    item.full_name,
                    role = Constant.Staff.Equals(item.role) ? "Nhân viên" : "Khách hàng"
                }).ToList();
        }

        private void frmMnStaff_Load(object sender, EventArgs e)
        {
            DisableButton();
            ToggleTextbox(false);
            var dicRole = new Dictionary<string, string>
            {
                { Constant.Staff, "Nhân viên" },
                { Constant.User, "Khách hàng" }
            };

            cboRole.DataSource = dicRole.ToList();
            cboRole.DisplayMember = "Value";
            cboRole.ValueMember = "Key";

            LoadData();

            dgvStaff.Columns[0].HeaderText = @"Mã tài khoản";
            dgvStaff.Columns[1].HeaderText = @"Email";
            dgvStaff.Columns[2].HeaderText = @"Tên";
            dgvStaff.Columns[3].HeaderText = @"Quyền";
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtID.Texts = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFullName.Text = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = _listAccount[e.RowIndex].password;
            var role = _listAccount.FirstOrDefault(item => item.user_id == Convert.ToInt32(txtID.Texts))?.role;
            cboRole.SelectedValue = role;

            if (Constant.Staff.Equals(role))
            {
                btnEdit.Text = @"Sửa";
                btnDel.Text = @"Xóa";
            }
            else
            {
                btnEdit.Text = @"Khóa";
                btnDel.Text = @"Mở khóa";
            }

            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;
            ToggleTextbox(false);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            DisableButton();
            ToggleTextbox(false);
            LoadData();
            cboRole.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToggleTextbox(true);
            ResetTextBox();
            EnableButton();
            cboRole.Visible = false;
            txtFullName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleTextbox(true);
            txtUsername.Enabled = false;
            EnableButton();
            cboRole.Visible = false;
            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var txtId = txtID.Texts.Trim();
                var fullname = txtFullName.Text.Trim();
                var email = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();
                var result = AccountBll.instance.Save(txtId, fullname, email, password);
                MessageBox.Show(result.data.ToString());
                if (result.isSuccess)
                {
                    btnReload_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Lỗi: {ex.Message}");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show(@"Vui lòng chọn nhân viên để xóa");
                return;
            }

            if (MessageBox.Show(@"Bạn chắc chắn muốn xóa nhân viên này?", @"Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                btnReload_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Lỗi: {ex.Message}");
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}