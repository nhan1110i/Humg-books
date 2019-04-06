using QLBanHang.GUI;
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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }
        public static string st1 = "";
        public static string st2 = "";
        private void button3_Click(object sender, EventArgs e)
        {
            st1 = dtpBatDau.Value.ToString().Substring(0, 10);

            st2 = dtpKetThuc.Value.ToString().Substring(0, 10);
            frmBaoCaoDoanhThu s = new frmBaoCaoDoanhThu();
            s.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKhachHang s = new frmKhachHang();
            s.ShowDialog();
        }
    }
}
