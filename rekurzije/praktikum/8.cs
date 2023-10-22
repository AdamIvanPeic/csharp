using System;

namespace rjesenje
{
    class Program
    {
        static int nzv(int a, int b, int r)
        {
            if (r % a == 0 && r % b == 0)
                return r;
            return nzv(a, b, r + 1);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int r = Math.Max(a, b);

            Console.WriteLine(nzv(a, b, r));

            Console.ReadKey();
        }
    }
}
