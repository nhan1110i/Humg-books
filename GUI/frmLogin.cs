using QLBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public static string tendangnhap = " ";
        public static string matkhau = "123456";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
        void dangnhap() {
            int cout = 0;
            string lenhSQL = "SELECT * FROM dbo.danhSachTaiKhoan";
            DataTable s = docDuLieu.Instance.Doc(lenhSQL);
            for (int i = 0; i < s.Rows.Count; i++) {
                if (txtDangNhap.Text.Trim() == s.Rows[i]["tenDangNhap"].ToString().Trim() && txtMatKhau.Text.Trim() == s.Rows[i]["matKhau"].ToString().Trim()) {
                    tendangnhap = s.Rows[i]["tenDangNhap"].ToString().Trim();
                    matkhau = s.Rows[i]["matKhau"].ToString().Trim();
                    cout++;
                    break;     
                }
            }
            if (cout == 1)
            {
                MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                Close();
            }
            else {
                lblLoi.Text = "Sai tên đăng nhập hoặc mật khẩu";
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
