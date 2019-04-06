using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
 public class Nguoi
    {
     public Nguoi() {
         ten = namsinh = sdt = diachi = " ";
     }
        public void setTen(string t){
            ten = t;
        }
        public string getTen() {
            return ten;
        }
        public void setNamSinh(string t) {
            namsinh = t;
        }
        public string getNamSinh() {
            return namsinh;
        }
        public void setDiaChi(string t) {
            diachi = t;
        }
        public string getDiaChi() {
            return diachi;
        }
        public void setSDT(string t) {
            sdt = t;
        }
        public string getSDT() {
            return sdt;
        }
        internal string ten;
        internal string namsinh;
        internal string diachi;
        internal string sdt;
    }
}
