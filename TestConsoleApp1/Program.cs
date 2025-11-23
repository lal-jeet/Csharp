using System;

namespace TestConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(19)); // True
            Console.WriteLine(IsPrime(49)); // False

            // Pause so you can see the output
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}