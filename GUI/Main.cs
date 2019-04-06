using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBanHang.DAO;

namespace QLBanHang
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dgvSachDaBan.DefaultCellStyle.Font = new Font("Sitka Banner", 12);
            dgvSachDaBan.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
            rf();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (frmLogin.tendangnhap == " ")
            {
                MessageBox.Show("Bạn cần phải đăng nhập","Thông báo");
            }
            else
            {
                frmDonBanHang s = new frmDonBanHang();
                s.ShowDialog();
                rf();
            }
        }
        
        //public DataGridView getdgv(DataGridView s) {
        //    return s;
        //}
        void rf() {
            string t = "SELECT * FROM dbo.sachDaBan";
            DataTable dt = docDuLieu.Instance.Doc(t);
            dt.Columns.Add("stt");
            for (int i = 0; i < dt.Rows.Count; i++) {
                dt.Rows[i]["stt"] = i + 1;
            }
            dgvSachDaBan.DataSource = dt;
            dgvSachDaBan.EnableHeadersVisualStyles = false;
            dgvSachDaBan.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (frmLogin.tendangnhap != "admin")
            {
                frmKhongDuQuyen s = new frmKhongDuQuyen();
                s.ShowDialog();
            }
            else {
                frmNhapHang s = new frmNhapHang();
                s.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin s = new frmLogin();
            s.ShowDialog();
            lblTenNV.Text = frmLogin.tendangnhap.ToUpper();
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (frmLogin.tendangnhap != "admin")
            {
                frmKhongDuQuyen st = new frmKhongDuQuyen();
                st.ShowDialog();
            }
            else
            {
                frmXoaDuLieu s = new frmXoaDuLieu();
                s.ShowDialog();
                rf();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKhoHang s = new frmKhoHang();
            s.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void chủCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin s = new frmThongTin();
            s.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/messages/t/nhan1110i");
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void danhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLogin.tendangnhap == "admin")
            {
                frmNhanVien s = new frmNhanVien();
                s.ShowDialog();
            }
            else {
                frmKhongDuQuyen st = new frmKhongDuQuyen();
                st.Show();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s = frmLogin.matkhau;
            if (frmLogin.tendangnhap == " ")
            {
                MessageBox.Show("Bạn cần đăng nhập");
            }
            else {
                if (frmLogin.tendangnhap != "admin")
                {
                    MessageBox.Show("Cần đăng nhập bằng tài khoản admin");
                }
                else {
                    frmDoiMatKhau dmk = new frmDoiMatKhau();
                    dmk.Show();
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin s = new frmLogin();
            s.ShowDialog();
            lblTenNV.Text = frmLogin.tendangnhap;

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmDoiMatKhau s = new frmDoiMatKhau();
            s.ShowDialog();
        }

        private void dgvSachDaBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      

        private void dgvSachDaBan_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmLogin.tendangnhap == "admin")
            {
                frmNhanVien s = new frmNhanVien();
                s.ShowDialog();
            }
            else {
                frmKhongDuQuyen st = new frmKhongDuQuyen();
                st.Show();
              }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmBaoCao s = new frmBaoCao();
            s.ShowDialog();
        }
       
    }
}
