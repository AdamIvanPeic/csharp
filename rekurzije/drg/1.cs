using System;

namespace rjesenje
{
    class Program
    {
        public static int funk(int n)
        {
            if (n == 1 || n == 2 || n == 3)
                return n;
            return funk(n - 1) + funk(n - 3);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(funk(n));

            Console.ReadKey();
        }
    }
}
