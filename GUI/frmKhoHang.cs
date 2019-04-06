using QLBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class frmKhoHang : Form
    {
        public frmKhoHang()
        {
            InitializeComponent();
            dgvKhoHang.DefaultCellStyle.Font = new Font("Sitka Banner", 12);
            hienthi();
        }
        void hienthi()
        {
           
            string lenhSQL = "SELECT * FROM dbo.dsSach";
            DataTable st = docDuLieu.Instance.Doc(lenhSQL);
            st.Columns.Add("stt");
            for (int i = 0; i < st.Rows.Count; i++) {
                st.Rows[i]["stt"] = i + 1;
            }
            dgvKhoHang.DataSource = st;
            
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string lenhSQL = "SELECT * FROM dbo.dsSach WHERE tenSach LIKE N'" + txtTimSach.Text.Trim() + "%'";
            dgvKhoHang.DataSource = docDuLieu.Instance.Doc(lenhSQL);
        }

        private void frmKhoHang_MouseClick(object sender, MouseEventArgs e)
        {
           
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaSach s = new frmSuaSach();
            s.ShowDialog();
            hienthi();
        }
        public static Sach sachSua = new Sach();
        
        int row_choose = 0;
        private void dgvKhoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnSua.Enabled = true;
            row_choose = dgvKhoHang.CurrentCell.RowIndex;
            if (dgvKhoHang.SelectedRows != null)
            {
                sachSua.setTenSach(dgvKhoHang.Rows[row_choose].Cells["tenSach"].Value.ToString().Trim());
                sachSua.setGiaTien(float.Parse(dgvKhoHang.Rows[row_choose].Cells["giaTien"].Value.ToString().Trim()));
                sachSua.setSoLuong(int.Parse(dgvKhoHang.Rows[row_choose].Cells["soLuongCon"].Value.ToString().Trim()));
                sachSua.setTacGia(dgvKhoHang.Rows[row_choose].Cells["tacGia"].Value.ToString().Trim());
            }
            else {
                MessageBox.Show("Không có dữ liệu về sách này","Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmthemSoLuong s = new frmthemSoLuong();
            s.ShowDialog();
            hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM dbo.dsSach WHERE tenSach = N'" + frmKhoHang.sachSua.getTenSach().Trim() + "'";
                changeSQL s = new changeSQL();
                s.oderSQL(sql);
                MessageBox.Show("Đã xóa", "Thông báo");
                hienthi();
            }
            else {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNhapHang s = new frmNhapHang();
            s.ShowDialog();
            hienthi();
        }

        private void dgvKhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmSuaGia s = new frmSuaGia();
            s.ShowDialog();
            hienthi();
        }
    }
}
