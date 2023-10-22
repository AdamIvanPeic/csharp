using System;

namespace rjesenje
{
    class Program
    {
        static bool potdva(double n)
        {
            if (n == 1)
                return true;
            if (n != (int)n)
                return false;
            return potdva(n / 2);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool r = potdva(n);

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
