using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chương_trình_quản_lý_thí_sinh_dự_thi_đại_học
{
    public abstract class ThongTinThiSinh : IThiSinh
    {
        private string hoTen;
        private string gioiTinh;
        private DateTime ngaySinh;
        private string soBD;
        private string diaChi;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string SoBD
        {
            get { return soBD; }
            set { soBD = value; }
        }

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public ThongTinThiSinh() { }
        public ThongTinThiSinh(string hoTen, string gioiTinh, DateTime ngaySinh, string soBD)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.soBD = soBD;
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhập số báo danh: ");
            SoBD = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhập giới tính");
            GioiTinh= Console.ReadLine();
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();
            DateTime ngaySinh = DateTime.ParseExact(input, "dd/MM/yyyy", null);
            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }
        public virtual void InThongTin()
        {
            Console.Write($"Ho va ten thi sinh: {HoTen}\n");
            Console.Write($"Gioi Tinh: {GioiTinh}\n");
            Console.Write($"Ngay Sinh: {NgaySinh.ToShortDateString()}\n");
            Console.Write($"So bao danh: {SoBD} \n");
        }

        public abstract double TinhTongDiem();
    }
}
