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
    public partial class frmmSuaNhanVien : Form
    {
        public frmmSuaNhanVien()
        {
            InitializeComponent();
            txtTen.Text = frmNhanVien.NhanVienSua.getTen().ToString().Trim();
            txtSoDienThoai.Text = frmNhanVien.NhanVienSua.getSDT().ToString().Trim();
            txtQuenQuan.Text = frmNhanVien.NhanVienSua.getDiaChi().ToString().Trim();
            txtTenDangNhap.Text = frmNhanVien.NhanVienSua.getTenDangNhap().ToString().Trim();
            txtMatKhau.Text = frmNhanVien.NhanVienSua.getMatKhau().ToString().Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SQL = "UPDATE dbo.danhSachTaiKhoan SET tenDangNhap = '" + txtTenDangNhap.Text.ToString().Trim() + "', matKhau ='" + txtMatKhau.Text.ToString().Trim() + "',tenNhanVien = N'" + txtTen.Text.ToString().Trim() + "',sdt = '" + txtSoDienThoai.Text.ToString().Trim() + "',queQuan =N'" + txtQuenQuan.Text.ToString().Trim() + "' WHERE tenNhanVien = N'" + frmNhanVien.NhanVienSua.getTen().ToString().Trim() + "'";
            changeSQL s = new changeSQL();
            s.oderSQL(SQL);
            MessageBox.Show("Đã Sửa", "Thông Báo");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
