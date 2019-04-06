using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
    public class NhanVien : Nguoi
    {
        public NhanVien() {
            tendangnhap = matkhau = " ";
        }
        public void setMatKhau(string t){
            matkhau = t;
        }
        public string getMatKhau() {
            return matkhau;
        }
        public void setTenDangNhap(string t) {
            tendangnhap = t;
        }
        public string getTenDangNhap() {
            return tendangnhap;
        }
        internal string tendangnhap;
       internal string matkhau;
    }
}
