using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chương_trình_quản_lý_thí_sinh_dự_thi_đại_học
{
    public abstract class ThongTinThiSinh : IThiSinh
    {
        public string MaSo { get; set; }
        public string Ten { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public Dictionary<string, double> Diem { get; set; }
        public ThongTinThiSinh()
        {
            Diem = new Dictionary<string, double>();
        }
        public  ThongTinThiSinh(string maSo, string ten, string gioiTinh,
                  DateTime ngaySinh, string diaChi,
                  Dictionary<string, double> diem)
        {
            MaSo = maSo;
            Ten = ten;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            Diem = diem ?? new Dictionary<string, double>();
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhập số báo danh: ");
            SoBD = Console.ReadLine()
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine()
            Console.Write("Nhập giới tính: ");
            GioiTinh = Console.ReadLine()
            // Kiểm tra ngày sinh
            DateTime ngaySinh;
            while (true)
            {
                Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
                string input = Console.ReadLine();
                //TryParseExact sẽ trả về kiểu true false
                if (DateTime.TryParseExact(input, "dd/MM/yyyy", null,
                                           System.Globalization.DateTimeStyles.None,
                                           out ngaySinh))
                {
                    NgaySinh = ngaySinh;
                    break;
                }
                else
                {
                    Console.WriteLine("❌ Ngày sinh không hợp lệ, vui lòng nhập lại theo định dạng dd/MM/yyyy.");
                }
                Console.Write("Nhập địa chỉ: ");
                DiaChi = Console.ReadLine();
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"Họ và tên thí sinh: {HoTen}");
            Console.WriteLine($"Giới tính: {GioiTinh}");
            Console.WriteLine($"Ngày sinh: {NgaySinh:dd/MM/yyyy}");
            Console.WriteLine($"Số báo danh: {SoBD}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
        }


        public abstract double TinhTongDiem();
    }
}
