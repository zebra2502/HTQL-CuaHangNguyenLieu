using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Class
{
     class CNhanVien:ANguoi
    {
        public string MaNhanVien;
        public string TenNhanVien;
        public string GioiTinh;
        public string DiaChi;
        public string DienThoai;
        public DateTime NgaySinh;
        public override void LayMa()
        {
            Console.WriteLine("{0}", this.MaNhanVien);
        }
        public override void LayTen()
        {
            Console.WriteLine("{0}",this.TenNhanVien);
        }
    }
}
