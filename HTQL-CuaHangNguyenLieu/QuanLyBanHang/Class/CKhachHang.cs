using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Class
{
    class CKhachHang : ANguoi
    {
        public string MaKhachHang;
        public string TenKhachHang;
        public string DiaChi;
        public string DienThoai;
        public override void LayMa()
        {
            Console.WriteLine("{0}", this.MaKhachHang);
        }
        public override void LayTen()
        {
            Console.WriteLine("{0}", this.TenKhachHang);
        }
    }
}