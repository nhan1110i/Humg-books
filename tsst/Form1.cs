using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tsst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable s = new DataTable("HocSinh");
            s.Columns.Add("ID", typeof(int));
            s.Columns.Add("TenHocSinh", typeof(string));
            int[] arrid = new int[] { 1, 2, 3, 4, 5 };
            string[] arrhoten = new string[] { "Thanh Lan", "Ngoc Lan", "Diep", "Hue", "Trang Lan" };
            for (int i = 0; i < arrid.Length; i++) { 
                Row s.DataTableNewRowEventArgs();
            }
        }
    }
}
