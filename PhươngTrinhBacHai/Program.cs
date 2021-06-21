using System;

namespace PhươngTrinhBacHai
{
    internal class Program
    {
        public delegate double PhuongTrinhBacHai(int a, int b, int c);

        public static double TinhToan(int a, int b, int c)
        {
            var Delta = Math.Pow(b, 2) - 4 * a * c;
            if (Delta > 0)
            {
                Console.WriteLine("Phuong Trinh Co Hai Nghiem: ");
                Console.WriteLine("x1 = {0}", (-b - Math.Sqrt(Delta)) / 2 * a);
                Console.WriteLine("x2 = {0}", (-b + Math.Sqrt(Delta)) / 2 * a);
            } else if (Delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep: ");
                Console.WriteLine("x1 = x2 = {0}", -b/2 * a);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }

            return Delta;
        }
        public static void Main(string[] args)
        {
            var phuongTrinhBacHai = new PhuongTrinhBacHai(TinhToan);
            var result = phuongTrinhBacHai(2, 6, 1);
            Console.WriteLine("Delta = {0}", result);
        }
    }
}