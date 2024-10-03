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
    public partial class frmThemNguoiDungVaoNhom : Form
    {
        public frmThemNguoiDungVaoNhom()
        {
            InitializeComponent();
            qL_NhomNguoiDungComboBox.SelectedIndexChanged += qL_NhomNguoiDungComboBox_SelectedIndexChanged;
            this.btnThem.Click += btnThem_Click;
        }

        void btnThem_Click(object sender, EventArgs e)
        {
            //TenDangNhap
            string tenDN = qL_NguoiDungDataGridView.CurrentRow.Cells[0].ToString();
            //MaNhom
            string maNhom = qL_NhomNguoiDungComboBox.SelectedValue.ToString();
            
            qL_NguoiDungNhomNguoiDungTableAdapter.Insert(tenDN, maNhom, string.Empty);
            qL_NguoiDungNhomNguoiDungTableAdapter.Xoa_NDNND(tenDN,maNhom);
            LoadND_NND();
            MessageBox.Show("Thành Công!");
        }
        public void LoadND_NND()
        {
            this.qL_NguoiDungNhomNguoiDung_DKTableAdapter.Fill_DK(this.module_DN.QL_NguoiDungNhomNguoiDung_DK, qL_NhomNguoiDungComboBox.SelectedValue.ToString());
        }

        void qL_NhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadND_NND();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void qL_NguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.module_DN);

        }

        private void frmThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'module_DN.QL_NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungNhomNguoiDungTableAdapter.Fill(this.module_DN.QL_NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'module_DN.QL_NhomNguoiDung' table. You can move, or remove it, as needed.
            this.qL_NhomNguoiDungTableAdapter.Fill(this.module_DN.QL_NhomNguoiDung);
            // TODO: This line of code loads data into the 'module_DN.QL_NguoiDung' table. You can move, or remove it, as needed.
            this.qL_NguoiDungTableAdapter.Fill(this.module_DN.QL_NguoiDung);

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
