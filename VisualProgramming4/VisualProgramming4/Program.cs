using System;

namespace VisualProgramming4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int G;
            Sum(out G);
            Console.WriteLine("Sum of value of G {0} ", G);
        }

        public static void Sum(out int G)
        {
            G = 80;
            G += G;

        }
    }
}
