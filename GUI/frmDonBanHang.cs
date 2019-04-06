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
using System.Data.SqlClient;
namespace QLBanHang
{
    public partial class frmDonBanHang : Form
    {
        public frmDonBanHang()
        {
            InitializeComponent();
        }
        public static float tien = 0;
        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Truy xuất lấy giá trị 1 cuốn sách + tác giả 
            // tính giá trị đơn giá * số lượng
            int cout = 0;
            string lenhSQL = "SELECT * FROM dbo.dsSach";
            DataTable s = docDuLieu.Instance.Doc(lenhSQL);
            for (int i = 0; i < s.Rows.Count; i++)
            {
                if (txtTenSach.Text.Trim() == s.Rows[i]["tenSach"].ToString().Trim())
                {
                    cout++;
                    lblTacGia.Text = s.Rows[i]["tacGia"].ToString().Trim();
                    lblDonGia.Text = s.Rows[i]["giaTien"].ToString().Trim();
                    break;
                }
            }
            if (cout == 0)
            {                
                MessageBox.Show("Không có sách trong CSDL", "Thông Báo");
                txtTenSach.Clear();
            }
            else
            {
                lblTongGiaTien.Text = (float.Parse(lblDonGia.Text) * int.Parse(txtSoLuong.Text)).ToString(); 
                themDuLieu();                
                string lenhSQL2 = "SELECT tenSach,soLuong,thanhTien FROM dbo.donHang";
                dgvDonHang.DataSource = docDuLieu.Instance.Doc(lenhSQL2);
                //tinh tien
                lblTongTien.Text = tinhTien().ToString() + " đ";
                // lay du lieu sang form hoadon
                tien = tinhTien();
                
            }
           
        }
        
        void themDuLieu() {
            string insertSQL = "INSERT INTO dbo.donHang (tenSach,soLuong,thanhTien,nhanVien) VALUES (N'" + txtTenSach.Text.ToString().Trim() + "'," + int.Parse(txtSoLuong.Text) + "," + float.Parse(lblTongGiaTien.Text) +",'"+lblNhanVien.Text.ToString().Trim()+ "')";
            changeSQL s = new changeSQL();
            s.oderSQL(insertSQL);
        }
        public float tinhTien() {
            float tong = 0;
            for (int i = 0; i < dgvDonHang.RowCount; i++) {
                tong = tong + float.Parse(dgvDonHang.Rows[i].Cells["thanhTien"].Value.ToString());
            }
            return tong;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wfsDonHang_Load(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString();
            lblNhanVien.Text = frmLogin.tendangnhap;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmHoaDon s = new frmHoaDon();
            s.ShowDialog();
        }

        public static ListView ListView1 { get; set; }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            int n = 1;
            if (int.TryParse(this.txtSoLuong.Text, out n))
            {

            }
            else {
                MessageBox.Show("Nhập số","Thông báo");
            }

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Them du lieu khach hang
            int sss = 0; 
            string sqlK = "SELECT * FROM dbo.khachHang";
            DataTable kh = docDuLieu.Instance.Doc(sqlK);
            for (int d = 0; d < kh.Rows.Count; d++) {
                if (kh.Rows[d]["sdt"].ToString().Trim() == txtsdt.Text.ToString().Trim()) {
                    int slm = int.Parse(kh.Rows[d]["soLanMua"].ToString().Trim()) + 1;
                    string sqq = "UPDATE dbo.khachHang SET soLanMua = " + slm + "WHERE sdt ='" + txtsdt.Text.ToString().Trim() + "'";
                    changeSQL mm = new changeSQL();
                    mm.oderSQL(sqq);
                    sss++;
                }
            }
            if (sss == 0) {
                string ssss = "INSERT INTO dbo.khachHang (tenKhach,sdt,soLanMua)VALUES(N'" + txtKhach.Text.ToString() + "','" + txtsdt.Text.ToString().Trim() + "'," + 1 + ")";
                changeSQL mmm = new changeSQL();
                mmm.oderSQL(ssss);
            }
            // tìm tenSach trong bang donHang de tru di tai bang dsSach
            string khohangSQL = "SELECT * FROM dbo.dsSach";
            DataTable khoHang = docDuLieu.Instance.Doc(khohangSQL);
            string donhangSQL = "SELECT * FROM dbo.donHang";
            DataTable donHang = docDuLieu.Instance.Doc(donhangSQL);
            for (int i = 0; i < donHang.Rows.Count; i++)
            {
                for (int j = 0; j < khoHang.Rows.Count; j++)
                {
                    if (donHang.Rows[i]["tenSach"].ToString().Trim() == khoHang.Rows[j]["tenSach"].ToString().Trim())
                    {
                        int soLuongCon = int.Parse(khoHang.Rows[j]["soLuongCon"].ToString().Trim());
                        int soLuongBan = int.Parse(donHang.Rows[i]["soLuong"].ToString().Trim());
                        int soLuongMoi = soLuongCon - soLuongBan;
                        string suaSQL = "UPDATE dbo.dsSach SET soLuongCon = " + soLuongMoi + " WHERE tenSach = N'" + donHang.Rows[i]["tenSach"].ToString().Trim() + "'";
                        changeSQL st = new changeSQL();
                        st.oderSQL(suaSQL);
                    }
                }
            }
            // thêm dữ liệu vào bảng sách đã bán
            string docSQL = "SELECT * FROM dbo.donHang";
            DataTable t = docDuLieu.Instance.Doc(docSQL);
            for (int k = 0; k < t.Rows.Count; k++) {
                string tenSach = t.Rows[k]["tenSach"].ToString().Trim();
                int soLuong = int.Parse(t.Rows[k]["soLuong"].ToString().Trim());
                string nhanVien = t.Rows[k]["nhanVien"].ToString().Trim();
                float thanhTien = float.Parse(t.Rows[k]["thanhTien"].ToString().Trim());
                string ngayThang = lblThoiGian.Text.Trim().Substring(0, 10);
                DateTime temp = Convert.ToDateTime(ngayThang);
                string lenhaddSQL = "INSERT INTO dbo.sachDaBan (tenSach,soLuong,thanhTien,tenNhanVien,ngayThang)VALUES(N'" + tenSach + "'," + soLuong + "," + thanhTien + ",N'" + nhanVien + "','"+temp+"')";
                changeSQL m = new changeSQL();
                m.oderSQL(lenhaddSQL);
            }
            // xóa bảng lưu tạm thời đơn hàng + hóa đơn
            string deleteSQL = "DELETE FROM dbo.donHang";
            changeSQL s = new changeSQL();
            s.oderSQL(deleteSQL);
            frmDaBan stt = new frmDaBan();
            stt.ShowDialog();
            Close();
        }

        private void lblTongGiaTien_Click(object sender, EventArgs e)
        {

        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
