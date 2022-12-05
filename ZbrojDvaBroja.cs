using System;

namespace Vjezbe
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Unesite prvi broj");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Zbroj=" + c);
            Console.ReadKey();
        }
    }
}
