using System;

namespace rjesenje
{
    class Program
    {
        public static void ispis(int n)
        {
            if(n == 1)
            {
                Console.Write(n + " ");
                return;
            }
            ispis(n-1);
            Console.Write(n + " ");
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ispis(n);

            Console.ReadKey();
        }
    }
}