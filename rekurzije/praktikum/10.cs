using System;

namespace rjesenje
{
    class Program
    {
        public static int[,] memo;
        public static int BK(int n, int r)
        {
            if (memo[n, r] != 0)
                return memo[n, r];
            if (r > n)
                return 0;
            if (r == 0 || r == n)
                return 1;

            int bk1 = BK(n - 1, r - 1) + BK(n - 1, r);
            memo[n, r] = bk1;

            return bk1;
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());

            memo = new int[n + 1, r + 1];
            int rj = BK(n, r);

            Console.WriteLine(rj);

            Console.ReadKey();
        }
    }
}
