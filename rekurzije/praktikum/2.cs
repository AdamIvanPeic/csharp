using System;

namespace rjesenje
{
    class Program
    {
        public static int suma(int n)
        {
            if (n == 1)
                return n;
            return suma(n - 1) + n*n;  
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(suma(n));

            Console.ReadKey();
        }
    }
}