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
    public partial class frmthemSoLuong : Form
    {
        public frmthemSoLuong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soLuongMoi = int.Parse(frmKhoHang.sachSua.getSoLuong().ToString().Trim()) +int.Parse(textBox1.Text.ToString().Trim());
            string lenhsql = "UPDATE dbo.dsSach SET soLuongCon = "+soLuongMoi+"WHERE tenSach = N'"+frmKhoHang.sachSua.getTenSach().ToString().Trim()+"'";
            changeSQL s = new changeSQL();
            s.oderSQL(lenhsql);
            MessageBox.Show("Đã thêm số lượng", "Thông Báo");
            Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
