using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.DAO
{
    class changeSQL
    {
        
        public static string constring = @"Data Source=DESKTOP-7OCJLBK\NHAN1110I;Initial Catalog=qlHangSach;Integrated Security=True";
        public void oderSQL(string updateSQL) {
            SqlConnection connect = new SqlConnection(constring);
            connect.Open();
            SqlCommand cmd2 = new SqlCommand(updateSQL, connect);
            cmd2.ExecuteNonQuery();
            connect.Close();
            
        }
        }
    }

