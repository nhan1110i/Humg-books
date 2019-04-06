using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang
{
 public class Sach
    {
        public Sach() {
            this.tenSach = tacGia = " ";
            soLuong = 1;
            giaTien = 1;
        }
        public void setTenSach(string t) {
            tenSach = t;
        }
        public string getTenSach() {
            return tenSach;
        }
        public void setTacGia(string t) {
            tacGia = t;
        }
        public string getTacGia() {
            return tacGia;
        }
        public void setSoLuong(int t) {
            soLuong = t;
        }
        public int getSoLuong() {
            return soLuong;
        }
        public void setGiaTien(float t) {
            giaTien = t;
        }
        public float getGiaTien() {
            return giaTien;
        }
        internal string tenSach;
        internal string tacGia;
        internal int soLuong;
        internal float giaTien;
    }
}
