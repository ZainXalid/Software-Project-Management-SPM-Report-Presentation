using System;

namespace VisualProgramming5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*Ref: parameters passed may be modified by method.
             * in: paramter passed  cannot be modified by method.
             * out: paramters must be modified by method.
             */ 
        


            int b;
            int c = 9;
            update(out b);
            change(ref c); //it's must to initialize value before passing ref.
            Console.WriteLine("update value is {0}", b);
            Console.WriteLine("update value is {0}", c);
        }
        public static void update(out int a)
        {
            a = 10;
        }
        public static void change(ref int d)
        {
            d = 11;
        }
    }
}
