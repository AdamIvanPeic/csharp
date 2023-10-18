using System;

namespace rjesenje
{
    class Program
    {
        public static int suma(int a, int b, int d)
        {
            if (a > b)
                return 0;
            return suma(a + d, b, d) + a;
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(suma(a, b, d));

            Console.ReadKey();
        }
    }
}