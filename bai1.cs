using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai_1_1010
{
    class diem
    {
        private double x;
        private double y;
        public diem()
        {
            x = 0;
            y = 0;
        }
        public diem(double ox, double oy)
        {
            x = ox;
            y = oy;
        }
        public void nhap()
        {
            Console.Write("Nhap hoanh do: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap tung do: ");
            y = double.Parse(Console.ReadLine());
        }
        public void Hienthi()
        {
            Console.WriteLine("Toa do la : ({0},{1})", x, y);
        }
        public double Khoangcach(diem d1, diem d2)
        {
            double kc = Math.Sqrt((d1.x - d2.x) * (d1.x - d2.x) + (d1.y - d2.y) * (d1.y - d2.y));
            return kc;
        }
        static void Main(string[] args)
        {
            diem t = new diem();
            t.nhap();
            t.Hienthi();
            Console.ReadKey();
        }
    }
}
