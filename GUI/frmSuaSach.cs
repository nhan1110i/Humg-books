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
    public partial class frmSuaSach : Form
    {
        public frmSuaSach()
        {
            InitializeComponent();
            txtTenSach.Text = frmKhoHang.sachSua.getTenSach();
            txtTacGia.Text = frmKhoHang.sachSua.getTacGia();
            lblSoLuong.Text = frmKhoHang.sachSua.getSoLuong().ToString();
            txtGiaBanLe.Text = frmKhoHang.sachSua.getGiaTien().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lenhSQl = "UPDATE dbo.dsSach SET tenSach = N'" + txtTenSach.Text.ToString().Trim() + "'," + "tacGia = N'" + txtTacGia.Text.ToString().Trim() + "'," + "giaTien =" + float.Parse(txtGiaBanLe.Text.ToString().Trim()) + "WHERE tenSach = N'" + frmKhoHang.sachSua.getTenSach().ToString().Trim() + "'";
            changeSQL s = new changeSQL();
            s.oderSQL(lenhSQl);
            MessageBox.Show("Sửa Thành Công", "Thông báo...");
            Close();

        }
    }
}
