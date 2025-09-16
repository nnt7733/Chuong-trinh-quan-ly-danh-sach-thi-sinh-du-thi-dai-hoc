using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiSinhDuThiDaiHoc
{
    public class ToHopA00 : ThongTinThiSinh
    {
        public override string MaToHop => "A00";
        public override string TenToHop => "Toán - Lý - Hóa";

        public ToHopA00() : base() { }

        public ToHopA00(string soBD, string hoTen, string gioiTinh,
                       DateTime ngaySinh, string diaChi)
            : base(soBD, hoTen, gioiTinh, ngaySinh, diaChi) { }

        protected override void NhapDiemCacMon()
        {
            DiemMonHoc["Toán"] = NhapDiemMon("Toán");
            DiemMonHoc["Lý"] = NhapDiemMon("Lý");
            DiemMonHoc["Hóa"] = NhapDiemMon("Hóa");
        }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Chi tiết điểm:");
            foreach (var mon in DiemMonHoc)
            {
                Console.WriteLine($"{mon.Key}: {mon.Value}");
            }
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
        }
    }
}
