using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectWin
{
    public partial class FrmProduct : Form
    {
        private List<Product> _list;
        private List<Category> _listCate;

        public FrmProduct()
        {
            InitializeComponent();
            _list = ProductBll.instance.FindAll();
        }

        private void ResetTextBox()
        {
            txtId.ResetText();
            txtName.ResetText();
            txtDes.ResetText();
            txtImage.ResetText();
            nmrPrice.Value = 0;
            nmrStock.Value = 0;
            nmrSold.Value = 0;
        }

        private void ToggleTextbox(bool state)
        {
            txtName.Enabled = state;
            txtDes.Enabled = state;
            cboCate.Enabled = state;
            nmrPrice.Enabled = state;
            nmrStock.Enabled = state;
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
            _list = ProductBll.instance.FindAll();
            dgv.DataSource = _list
                .Select(item => new
                {
                    item.product_id,
                    item.product_name,
                    item.category.category_name,
                    item.price,
                    item.stock,
                    item.sold
                })
                .ToList();
            _listCate = CategoryBll.instance.FindAll();
            cboCate.DataSource = _listCate.ToList();
            cboCate.DisplayMember = "category_name";
            cboCate.ValueMember = "category_id";
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            txtId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            cboCate.SelectedValue = _list
                .FirstOrDefault(item => item.product_id == Convert.ToInt32(txtId.Text))?.category_id;
            nmrPrice.Value = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[3].Value);
            nmrStock.Value = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[4].Value);
            nmrSold.Value = Convert.ToDecimal(dgv.Rows[e.RowIndex].Cells[5].Value);
            txtImage.Text = _list[e.RowIndex].product_image;
            txtDes.Text = _list[e.RowIndex].description;

            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnSave.Enabled = false;
        }

        private void frmMnCustomer_Load(object sender, EventArgs e)
        {
            ToggleTextbox(false);
            DisableButton();
            LoadData();
            dgv.Columns[0].HeaderText = @"Mã sản phẩm";
            dgv.Columns[1].HeaderText = @"Tên sản phẩm";
            dgv.Columns[2].HeaderText = @"Loại sản phẩm";
            dgv.Columns[3].HeaderText = @"Giá";
            dgv.Columns[4].HeaderText = @"Tồn kho";
            dgv.Columns[5].HeaderText = @"Đã bán";
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
                MessageBox.Show(@"Vui lòng chọn sản phẩm để xóa");
                return;
            }

            if (MessageBox.Show(@"Bạn chắc chắn muốn xóa sản phẩm này?", @"Xác nhận", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var result = AccountBll.instance.Delete(txtId.Text.Trim());
                    MessageBox.Show(result.data.ToString());
                    if (result.isSuccess)
                    {
                        btnCancel_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($@"Lỗi: {ex.Message}");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            DisableButton();
            ToggleTextbox(false);
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var productId = txtId.Text.Trim();
                var productName = txtName.Text.Trim();
                var productDes = txtDes.Text.Trim();
                var productPrice = nmrPrice.Value;
                var productStock = nmrStock.Value;
                var productCate = cboCate.SelectedValue.ToString();
                var productImage = txtImage.Text.Trim();

                var result = ProductBll.instance.Save(productId, productName, productImage, productDes,
                    Convert.ToInt32(productCate), productPrice, productStock);

                ShowMessage(result.data.ToString());
                if (result.isSuccess)
                {
                    btnCancel_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                ShowErr(ex);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (var open = new OpenFileDialog())
                {
                    // image filters  
                    open.Filter = @"Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        var selectedImagePath = open.FileName;

                        // Đọc tệp thành byte array
                        var imageBytes = File.ReadAllBytes(selectedImagePath);

                        var fileExtension = Path.GetExtension(selectedImagePath).ToLower();

                        // Xác định MIME type dựa trên đuôi file
                        string mimeType;

                        // Sử dụng cách viết thông thường thay vì recursive pattern:
                        switch (fileExtension)
                        {
                            case ".png":
                                mimeType = "image/png";
                                break;
                            case ".gif":
                                mimeType = "image/gif";
                                break;
                            case ".bmp":
                                mimeType = "image/bmp";
                                break;
                            default:
                                mimeType = "image/jpeg";
                                break;
                        }

                        // Tạo Base64 path hoàn chỉnh
                        var base64String = $"data:{mimeType};base64,{Convert.ToBase64String(imageBytes)}";

                        // Hiển thị Base64 path hoàn chỉnh trong TextBox
                        txtImage.Text = base64String;
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErr(ex);
            }
        }

        private void ShowErr(Exception ex)
        {
            MessageBox.Show($@"Lỗi: {ex.Message}");
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}