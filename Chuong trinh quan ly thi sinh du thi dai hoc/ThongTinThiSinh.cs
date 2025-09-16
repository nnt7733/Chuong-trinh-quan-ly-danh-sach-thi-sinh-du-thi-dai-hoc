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
        // theo chương trình 2025 thì toán và văn là 2 môn bắt buộc
        private double diemToan;
        private double diemVan;
        private double diemAnh;
        private double diemLy;
        private double diemHoa;
        private double diemSinh;
        private double diemSu;
        private double diemDia;
        private double diemCongDan;
        private double diemTin;
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
        // sẽ kiểm tra điều kiện nhập sau!
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
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public double DiemToan
        {
            get { return diemToan; }
            set { diemToan = value; }
        }
        public double DiemVan
        {
            get { return diemVan; }
            set { diemVan = value; }
        }
        public double DiemAnh
        {
            get { return diemAnh; }
            set { diemAnh = value; }
        }
        public double DiemLy
        {
            get { return diemLy; }
            set { diemLy = value; }
        }
        public double DiemHoa
        {
            get { return diemHoa; }
            set { diemHoa = value; }
        }
        public double DiemSinh
        {
            get { return diemSinh; }
            set { diemSinh = value; }
        }
        public double DiemSu
        {
            get { return diemSu; }
            set { diemSu = value; }
        }
        public double DiemDia
        {
            get { return diemDia; }
            set { diemDia = value; }
        }
        public double DiemCongDan
        {
            get { return diemCongDan; }
            set { diemCongDan = value; }
        }
        public double DiemTin
        {
            get { return diemTin; }
            set { diemTin = value; }
        }

        public ThongTinThiSinh() { }
        public ThongTinThiSinh(string hoTen, string gioiTinh, DateTime ngaySinh, string soBD, string diaChi)
        {
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.soBD = soBD;
            this.diaChi = diaChi;
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
            Console.Write($"Địa chỉ: {DiaChi}\n");
        }

        public abstract double TinhTongDiem();
    }
}
