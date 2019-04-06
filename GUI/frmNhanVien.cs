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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            dgvNhanVien.DefaultCellStyle.Font= new Font("Sitka Banner", 12);
            rf();
        }
        void rf() {
            string odersql = "SELECT * FROM dbo.danhSachTaiKhoan WHERE tenDangNhap <> 'admin'";
            dgvNhanVien.DataSource = docDuLieu.Instance.Doc(odersql);

        }
        public static NhanVien NhanVienSua = new NhanVien();
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvNhanVien.CurrentCell.RowIndex;
            NhanVienSua.setTen(dgvNhanVien.Rows[row].Cells["tenNhanVien"].Value.ToString().Trim());
            NhanVienSua.setSDT(dgvNhanVien.Rows[row].Cells["sdt"].Value.ToString().Trim());
            NhanVienSua.setDiaChi(dgvNhanVien.Rows[row].Cells["queQuan"].Value.ToString().Trim());
            NhanVienSua.setTenDangNhap(dgvNhanVien.Rows[row].Cells["tenDangNhap"].Value.ToString().Trim());
            NhanVienSua.setMatKhau(dgvNhanVien.Rows[row].Cells["matKhau"].Value.ToString().Trim());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmmSuaNhanVien s = new frmmSuaNhanVien();
            s.ShowDialog();
            rf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSuaNhanVien s = new frmSuaNhanVien();
            s.ShowDialog();
            rf();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa nhân viên: " + frmNhanVien.NhanVienSua.getTen().ToString().Trim() + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM dbo.danhSachTaiKhoan WHERE tenNhanVien = N'" + frmNhanVien.NhanVienSua.getTen().ToString().Trim() + "'";
                changeSQL s = new changeSQL();
                s.oderSQL(sql);
                MessageBox.Show("Đã Xóa", "Thông Báo");
                rf();
            }
            else {
                this.Close();
            }
            
            
        }
    }
}
