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
    public partial class frmSuaNhanVien : Form
    {
        public frmSuaNhanVien()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO dbo.danhSachTaiKhoan (tenDangNhap,matKhau,tenNhanVien,sdt,queQuan) VALUES ('"+txtTenDangNhap.Text.ToString().Trim() + "','"+txtMatKhau.Text.ToString().Trim() + "',N'" +txtTen.Text.ToString().Trim()+"','"+txtSoDienThoai.Text.ToString().Trim() + "',N'"+txtQuenQuan.Text.ToString().Trim()+"')";
            changeSQL s = new changeSQL();
            s.oderSQL(sql);
            MessageBox.Show("Đã thêm nhân viên mới", "Thông báo");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
