using System;

namespace rjesenje
{
    class Program
    {
        public static int[] memo;
        public static int el(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            if (n == 3)
                return 3;

            if (memo[n - 1] != 0)
                return memo[n - 1];

            int s_el = el(n - 1) + el(n - 2) + el(n - 3);
            memo[n - 1] = s_el;

            return s_el;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            memo = new int[n];
            int r = el(n);

            Console.WriteLine(r);

            Console.ReadKey();
        }
    }
}
