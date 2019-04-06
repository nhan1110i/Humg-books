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
    public partial class frmSuaGia : Form
    {
        public frmSuaGia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE dbo.dsSach SET giaTien = " + float.Parse(textBox1.Text.ToString().Trim()) + "WHERE tenSach = N'" + frmKhoHang.sachSua.getTenSach().ToString().Trim() + "'";
            changeSQL s = new changeSQL();
            s.oderSQL(sql);
            MessageBox.Show("Đã sửa giá tiền", "Thông báo");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
