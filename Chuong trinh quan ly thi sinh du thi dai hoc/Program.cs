using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThiSinhDuThiDaiHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IThiSinh> hs = new List<IThiSinh>();

            Console.Write("Nhập số lượng thí sinh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Nhập thông tin thí sinh thứ {i + 1} ---");

                IThiSinh ts = new ToHopA00();
                ts.NhapThongTin();
                ts.NhapDiem();
                hs.Add(ts);
            }
            Console.WriteLine("\n=== DANH SÁCH THÍ SINH ===");
            foreach (var ts in hs)
            {
                ts.InThongTin();
            }
        }
    }
}
