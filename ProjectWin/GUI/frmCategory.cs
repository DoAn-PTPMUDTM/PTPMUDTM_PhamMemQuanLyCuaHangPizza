using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace ProjectWin
{
    public partial class FrmCategory : Form
    {
        private List<Category> _categories;

        public FrmCategory()
        {
            InitializeComponent();
            _categories = CategoryBll.instance.FindAll();
        }

        private void ResetTextBox()
        {
            txtId.ResetText();
            txtName.ResetText();
            txtDes.ResetText();
        }

        private void ToggleTextbox(bool state)
        {
            txtName.Enabled = state;
            txtDes.Enabled = state;
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
            _categories = CategoryBll.instance.FindAll();

            dgv.DataSource = _categories.Select(item => new
            {
                item.category_id,
                item.category_name,
                item.description
            }).ToList();
        }


        private void frmMnFood_Load(object sender, EventArgs e)
        {
            DisableButton();
            ToggleTextbox(false);
            LoadData();
            dgv.Columns[0].HeaderText = @"Mã danh mục";
            dgv.Columns[1].HeaderText = @"Tên danh mục";
            dgv.Columns[2].HeaderText = @"Mô tả";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ToggleTextbox(true);
            ResetTextBox();
            EnableButton();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ToggleTextbox(true);
            EnableButton();
            txtName.Focus();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text.Trim()))
            {
                MessageBox.Show(@"Vui lòng chọn danh mục để xóa");
                return;
            }

            if (MessageBox.Show(@"Bạn chắc chắn muốn xóa danh mục này?", @"Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;

            var result = CategoryBll.instance.Remove(txtId.Text.Trim());
            if (result.isSuccess)
            {
                MessageBox.Show(result.data.ToString());
                btnReload_Click(sender, e);
            }
            else
            {
                MessageBox.Show(result.data.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cateId = txtId.Texts.Trim();
            var cateName = txtName.Text.Trim();
            var cateDes = txtDes.Text.Trim();

            var result = CategoryBll.instance.Save(cateId, cateName, cateDes);
            if (result.isSuccess)
            {
                MessageBox.Show(result.data.ToString());
                btnReload_Click(sender, e);
            }
            else
            {
                MessageBox.Show(result.data.ToString());
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            DisableButton();
            ToggleTextbox(false);
            LoadData();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtDes_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtId.Texts = _categories[e.RowIndex].category_id.ToString();
            txtName.Text = _categories[e.RowIndex].category_name;
            txtDes.Text = _categories[e.RowIndex].description;

            btnEdit.Enabled = true;
            btnDel.Enabled = true;

            btnSave.Enabled = false;
        }
    }
}