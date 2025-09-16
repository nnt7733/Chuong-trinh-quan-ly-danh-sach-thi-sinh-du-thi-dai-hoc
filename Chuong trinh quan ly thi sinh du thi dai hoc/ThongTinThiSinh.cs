using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiSinhDuThiDaiHoc
{
    public abstract class ThongTinThiSinh : IThiSinh
    {
        public string SoBD { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public abstract string MaToHop { get; }
        public abstract string TenToHop { get; }

        // Dictionary để lưu điểm các môn
        public Dictionary<string, double> DiemMonHoc { get; set; }

        public ThongTinThiSinh()
        {
            DiemMonHoc = new Dictionary<string, double>();
        }

        public ThongTinThiSinh(string soBD, string hoTen, string gioiTinh,
                  DateTime ngaySinh, string diaChi)
        {
            SoBD = soBD;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DiemMonHoc = new Dictionary<string, double>();
        }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhập số báo danh: ");
            SoBD = Console.ReadLine();

            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine();

            // Kiểm tra ngày sinh
            DateTime ngaySinh;
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string input = Console.ReadLine();
                if (DateTime.TryParseExact(input, "dd/MM/yyyy", null,
                                           System.Globalization.DateTimeStyles.None,
                                           out ngaySinh))
                {
                    NgaySinh = ngaySinh;
                    break;
                }
                else
                {
                    Console.WriteLine("Ngày sinh không hợp lệ, vui lòng nhập lại theo định dạng dd/MM/yyyy.");
                }
            }

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"THÔNG TIN THÍ SINH TỔ HỢP {MaToHop}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"Họ và tên: {HoTen}");
            Console.WriteLine($"Số báo danh: {SoBD}");
            Console.WriteLine($"Giới tính: {GioiTinh}");
            Console.WriteLine($"Ngày sinh: {NgaySinh:dd/MM/yyyy}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Tổ hợp: {MaToHop} - {TenToHop}");
            Console.WriteLine($"Tổng điểm: {TinhTongDiem():F2}");
        }

        public virtual void NhapDiem()
        {
            Console.WriteLine($"\n NHẬP ĐIỂM THÍ SINH TỔ HỢP {MaToHop}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");

            NhapDiemCacMon();
        }

        protected double NhapDiemMon(string tenMon)
        {
            double diem;
            while (true)
            {
                Console.Write($"Nhập điểm {tenMon} (0-10): ");
                if (double.TryParse(Console.ReadLine(), out diem) && diem >= 0 && diem <= 10)
                {
                    return diem;
                }
                Console.WriteLine("Điểm không hợp lệ. Vui lòng nhập điểm từ 0 đến 10.");
            }
        }

        protected abstract void NhapDiemCacMon();

        public virtual double TinhTongDiem()
        {
            return DiemMonHoc.Values.Sum();
        }
    }
}