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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
            dgvHoaDon.DefaultCellStyle.Font = new Font("Sitka Banner", 12);
            loadHoaDon();
        }
        void loadHoaDon() {
            string lenhSQL = "SELECT tenSach,soLuong,thanhTien FROM dbo.donHang";
            dgvHoaDon.DataSource = docDuLieu.Instance.Doc(lenhSQL);
            lblTongHoaDon.Text = frmDonBanHang.tien.ToString() + " đ";
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            

        }
      
    }
}
