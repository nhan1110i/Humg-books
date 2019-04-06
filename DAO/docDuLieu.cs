using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLBanHang.DAO
{
    public class docDuLieu
    {
        private static docDuLieu instance;

        public static docDuLieu Instance
        {
            get { if (instance == null) {
                instance = new docDuLieu();
            } return docDuLieu.instance; }
            set { docDuLieu.instance = value; }
        }
      public static string constring = @"Data Source=DESKTOP-7OCJLBK\NHAN1110I;Initial Catalog=qlHangSach;Integrated Security=True";
       public DataTable Doc(string lenhSQL) {
           DataTable data = new DataTable();
           using(SqlConnection sqlc = new SqlConnection(constring))
           {
           sqlc.Open();
           SqlCommand cmd = new SqlCommand(lenhSQL, sqlc);
           cmd.CommandType = CommandType.Text;
           SqlDataAdapter adapter = new SqlDataAdapter(cmd);
           adapter.Fill(data);
           sqlc.Close();
           return data;
       }
       }
    }
}
