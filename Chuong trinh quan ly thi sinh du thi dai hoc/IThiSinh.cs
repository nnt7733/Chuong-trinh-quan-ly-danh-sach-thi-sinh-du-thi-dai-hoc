using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiSinhDuThiDaiHoc
{
    public interface IThiSinh
    {
        string SoBD { get; set; }
        string HoTen { get; set; }
        string GioiTinh { get; set; }
        DateTime NgaySinh { get; set; }
        string DiaChi { get; set; }
        string MaToHop { get; } 
        string TenToHop { get; } 

        void NhapThongTin();
        void InThongTin();
        double TinhTongDiem();
        void NhapDiem();
    }
}
