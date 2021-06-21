using System;

namespace lab06
{
    internal class Program
    {
        // public delegate void Increment(ref int x);
        //
        // public static void Add2(ref int x)
        // {
        //     x += 2;
        // }
        //
        // public static void Add3(ref int x)
        // {
        //     x += 3;
        // }
        // public static void Main(string[] args)
        // {
        //     var increment = new Increment(Add2);
        //     increment += Add3;
        //     increment += Add2;
        //     var x = 5;
        //     increment(ref x);
        //     Console.WriteLine(x);
        // }
        
        
        
        //Tinh Tổng Ba Số
        public delegate int ThangDelegate(int a, int b, int c);

        public static int TinhTongBaSo(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void Main(string[] args)
        {
            var thangDelegate = new ThangDelegate(TinhTongBaSo);
            var result = thangDelegate(4, 2, 9);
            Console.WriteLine(result);
        }
    }
}