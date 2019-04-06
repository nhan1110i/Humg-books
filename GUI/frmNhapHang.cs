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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tim(txtTenSachMoi.Text.Trim())){ 
                MessageBox.Show("Sách đã có");
            }else{
             string insertSQL = "INSERT INTO dbo.dsSach (tenSach,tacGia,giaTien,soLuongCon)VALUES(N'"+txtTenSachMoi.Text.Trim()+"',N'"+txtTacGiaMoi.Text.Trim()+"',"+float.Parse(txtGiaBanLeMoi.Text.Trim())+","+int.Parse(txtSoLuongSachMoi.Text.Trim()) +")";
            changeSQL s = new changeSQL();
            s.oderSQL(insertSQL);
            MessageBox.Show("Đã thêm sách vào kho hàng");
            this.Close();
            }
        }
        bool tim(string s) {
            int cout = 0;
            string timSQL = "SELECT * FROM dbo.dsSach";
            DataTable s1 = docDuLieu.Instance.Doc(timSQL);
            for (int i = 0; i < s1.Rows.Count; i++) {
                if (s == s1.Rows[i]["tenSach"].ToString().Trim()) {
                    cout++;
                    break;
                }
            }
            if (cout == 0)
            {
                return false;
            }
            else {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
