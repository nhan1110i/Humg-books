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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public static string matkhau = "";
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT * FROM dbo.danhSachTaiKhoan";
            string updateSQL = "UPDATE dbo.danhSachTaiKhoan SET matKhau ='" + txtMatKhauMoi.Text.Trim() + "'WHERE tenDangNhap = 'admin'";
            DataTable s = docDuLieu.Instance.Doc(sql);
            if (s.Rows[0]["matKhau"].ToString().Trim() == txtMatKhauCu.Text.Trim())
            {
                changeSQL td = new changeSQL();
                td.oderSQL(updateSQL);
                MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thông Báo");
                Close();
            }
            else {
                MessageBox.Show("Sai Mật Khẩu");
            }
        }
    }
}
