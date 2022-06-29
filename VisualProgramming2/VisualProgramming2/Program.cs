using System;

namespace VisualProgramming2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A v1 = new A(12);
            A v2 = new A(13);

            v2 = v1;

            Console.WriteLine(v1.value);
            Console.WriteLine(v2.value);
        }
    }

    class A
    {
        public int value
        {
            get;
            set;
        }
        public A(int passbyref)
        {
            this.value = passbyref;
        }
    }
}
