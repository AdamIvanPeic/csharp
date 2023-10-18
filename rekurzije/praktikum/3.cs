//može li drukčije?
using System;

namespace rjesenje
{
    class Program
    {
        public static int suma(int n)
        {
            if (n == 1)
                return n;

            return suma(n - 2) + n;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = n * 2;
            n = n - 1;
            Console.WriteLine(suma(n));

            Console.ReadKey();
        }
    }
}