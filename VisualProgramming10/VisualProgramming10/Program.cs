using System;

namespace VisualProgramming10
{
    class Program
    {
        static void Main(string[] args)
        {
          //  d_class d = new d_class();
          //  d.fun();

            base_class b = new base_class();
            b.fun(); //parent
            b = new d_class();
            b.fun(); //child
        }
    }

    class base_class
    {
        int n1, n2;
        public base_class()
        {
            Console.WriteLine("Default Constructor in Base Class");
        }

        public base_class(int i, int j)
        {
            n1 = i;
            n2 = j;
            Console.WriteLine("para const ind base class.");
        }

        public virtual void fun()
        {
            Console.WriteLine("Base Class");

        }
    }

    class d_class : base_class
    {
       new public void fun()
        {

            Console.WriteLine("Derived Class");
        }
    }
}
