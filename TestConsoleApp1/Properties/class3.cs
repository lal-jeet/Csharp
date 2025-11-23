using System;

namespace TestConsoleApp1
{
    public class PrintFibonacci
    {
        public static void PrintFibonacciSequence(int count)
        {
            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 1; i <= count; i++)
            {
                Console.Write(a + ", ");

                a = b;
                b = c;
                c = a + b;
            }

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            PrintFibonacciSequence(10);

            // Pause so you can see the output when running from Visual Studio
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}