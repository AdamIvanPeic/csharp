using System;

namespace rjesenje
{
    class Program
    {
        public static double s1(int n)
        {
            if (n == 1)
                return n;
            return s1(n - 1) + 1.0D/n;
        }
        public static double s2(int n)
        {
            if (n == 1)
                return -1;
            return s2(n - 1) + Math.Pow(-1, n)*n;
        }
        public static double s3(int n)
        {
            if (n == 2)
                return 1.0D/2;
            return s3(n - 2) + Math.Pow(-1, n/2 - 1) * (1.0D / n);
        }
        public static double s4(int n)
        {
            if (n == 3)
                return 1.0D / 3;
            return s4(n - 2) + 1.0D / n;
        }
        public static double s5(int n)
        {
            if (n == 1)
                return 1.0D / 2;
            return s5(n - 2) + n / (n + 1.0D);
        }
        public static double s6(int n)
        {
            if (n == 1)
                return 1;
            return s6(n - 1) + Math.Pow(-1, n - 1) * Math.Pow(1.0D / n, 2);
        }
        public static double s7(int n)
        {
            if (n == 5)
                return 3.0D / 5;
            return s7(n - 4) + (n - 2.0D) / n;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(s1(n) + " ");
            Console.Write(s2(n) + " ");
            int t = n * 2;
            Console.Write(s3(t) + " ");
            t = n * 2 + 1;
            Console.Write(s4(t) + " ");
            t = n * 2 - 1;
            Console.Write(s5(t) + " ");
            Console.Write(s6(n) + " ");
            t = n * 3 + n + 1;
            Console.Write(s7(t) + " ");

            Console.ReadKey();
        }
    }
}
