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

namespace QLBanHang.GUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
            rf();
        }
        void rf() { 
            string st = "SELECT * FROM dbo.khachHang";
            DataTable s = docDuLieu.Instance.Doc(st);
            s.Columns.Add("STT");
            for (int i = 0; i < s.Rows.Count; i++) {
                s.Rows[i]["STT"] = i + 1;
            }
            dgvKhachHang.DataSource = s;
            
        }
    }
}
