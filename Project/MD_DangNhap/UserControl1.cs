using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien;
namespace MD_DangNhap
{
    public partial class UserControl1: UserControl
    {
        public event EventHandler GetChangeKQ;
        QL_NguoiDung CauHinh = new QL_NguoiDung();
        String _ChuoiCauhinh;
        bool _TT;

        public bool TT
        {
            get { return _TT; }
            set { _TT = value; }
        }

        public string ChuoiCauhinh
        {
            get { return _ChuoiCauhinh; }
            set { _ChuoiCauhinh = value; }
        }

        public UserControl1()
        {
            InitializeComponent();
            this.btnDN.Click += btnDN_Click;
            this.btnThoat.Click += btnThoat_Click;
        }

        void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void btnDN_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + lblUsername.Text.ToLower());
                this.txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {
                MessageBox.Show("Không được bỏ trống" + lblPassword.Text.ToLower());
                this.txtPassword.Focus();
                return;
            }
            CauHinh.ChuoiCauhinh = ChuoiCauhinh;
            if (CauHinh.Check_Config() == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            //if (CauHinh.Check_Config() == 1)
            //{
            //    MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
            //    ProcessConfig();
            //}
            //if (CauHinh.Check_Config() == 2)
            //{
            //    MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
            //    ProcessConfig();
            //} 
        }
        
        public void ProcessLogin()
        {
            LoginResult result;
            result = CauHinh.Check_User(txtUsername.Text, txtPassword.Text); //Check_User viết trong Class QL_NguoiDung
            // Wrong username or pass
            if (result == LoginResult.Invalid)
            {
                MessageBox.Show("Sai " + lblUsername.Text + " Hoặc " + lblPassword.Text);
                _TT = false;
                return;
            }
            // Account had been disabled
            else if (result == LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản bị khóa");
                _TT = false;
                return;
            }

            //Thông tin đăng nhập thành công
            MessageBox.Show("Đăng nhập thành công!");
            _TT = true;
            GetChangeKQ.Invoke(this, EventArgs.Empty);
            
        }
    }
}
