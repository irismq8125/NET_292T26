using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_292T26
{
    internal class Program
    {
        //code method
        public int Sum_1(int x, int y)
        {
            int kq = x + y;
            return kq;
        }
        public double Sum_2(int x, int y)
        {
            return x + y;
        }
        public int Sum_3(int x, int y) { return x + y; }
        public static int Sum_4(int x, int y) => x + y; 
        public static void Sum_5(int x, int y) => Console.WriteLine("Tong la: {0}", x + y);

        public static void NhanVien(string hoten, int lcb, float hsl = 2.34f) => Console.WriteLine(hoten + " " + lcb + " " + hsl);

        static void Main(string[] args)
        {

            NhanVien("Nguyen Van A", 1000000, 2.67f); // Nguyen Van A 1000000 2.67
            Console.WriteLine(); 
            NhanVien("Nguyen Van B", 2000000); // Nguyen Van B 2000000 2.34


            int songuyen = 10;
            var soNguyen = 10;

            string a = "ABCD";
            var b = "ABCD";


            //Console.WriteLine("Nhap gia tri n = ");
            //int n1 = int.Parse(Console.ReadLine());

            //int n2 = 0;
            //bool n3 = int.TryParse(Console.ReadLine(), out n2);

            //ham khong co kieu du lieu tra ve
            //Sum_5(3,6);
            //Console.WriteLine();
            ////ham co kieu du lieu tra ve
            //int kq = Sum_4(3, 6);
            //Console.WriteLine("Tong la: {0}", kq);
            //Console.WriteLine("Tong la: {0}", Sum_4(3, 6));

            //if(Sum_4(3, 6) % 2 == 0) Console.WriteLine("So chan");
            //else Console.WriteLine("So le");


            Console.ReadKey();
        }
        //code method
    }
}
