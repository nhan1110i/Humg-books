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
    public partial class frmBaoCaoDoanhThu : Form
    {
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
            rf();
        }
        void rf() {
            lblThoiGian.Text ="( "+ frmBaoCao.st1.Trim() + "    đến    " + frmBaoCao.st2.Trim()+" )";
            string s = "SELECT tenSach,soLuong,thanhTien,tenNhanVien,ngayThang FROM dbo.sachDaBan WHERE ngayThang BETWEEN CAST('"+frmBaoCao.st1+"' AS DATE) AND CAST('"+frmBaoCao.st2+"' AS DATE)";
            DataTable temp = docDuLieu.Instance.Doc(s);
            dgvBaoCao.DataSource = temp;
            double tongTien = 0;
            int soSach = 0;
            for (int i = 0; i < temp.Rows.Count; i++) {
                tongTien = tongTien + double.Parse(temp.Rows[i]["thanhTien"].ToString().Trim());
                soSach = soSach + int.Parse(temp.Rows[i]["soLuong"].ToString().Trim());
            }
            lblTongSach.Text = soSach.ToString().Trim() ;
            lblThanhTien.Text = tongTien.ToString().Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            string t = "SELECT tenSach,soLuong,thanhTien,tenNhanVien,ngayThang FROM dbo.sachDaBan WHERE ngayThang BETWEEN CAST('" + frmBaoCao.st1 + "' AS DATE) AND CAST('" + frmBaoCao.st2 + "' AS DATE)";
            DataTable s = docDuLieu.Instance.Doc(t);
            DataRow __newRow = s.NewRow();
            __newRow["tenSach"] = "TỔNG TIỀN HÀNG";
            __newRow["soLuong"] = lblTongSach.Text;
            __newRow["thanhTien"] = lblThanhTien.Text;
            s.Rows.Add(__newRow);
            excel.Export(s, "Danh Sach", "Số Sách Đã Bán");
        }
    }
}
