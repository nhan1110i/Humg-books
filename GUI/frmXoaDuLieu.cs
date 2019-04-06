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
    public partial class frmXoaDuLieu : Form
    {
        public frmXoaDuLieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa dữ liệu sách đã bán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM dbo.sachDaBan";
                changeSQL s = new changeSQL();
                s.oderSQL(sql);
                MessageBox.Show("ĐÃ XÓA", "thông báo");
            }
            else {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("Bạn thật sự muốn xóa toàn bộ nhân viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM dbo.danhSachTaiKhoan WHERE tenDangNhap <> 'admin'";
                    changeSQL s = new changeSQL();
                    s.oderSQL(sql);
                    MessageBox.Show("ĐÃ XÓA", "thông báo");
                }
                else
                {
                    Close();
                }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa toàn bộ khách hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "DELETE FROM dbo.khachHang";
                changeSQL s = new changeSQL();
                s.oderSQL(sql);
                MessageBox.Show("ĐÃ XÓA", "thông báo");
            }
            else
            {
                Close();
            }
        }
        }
    }

