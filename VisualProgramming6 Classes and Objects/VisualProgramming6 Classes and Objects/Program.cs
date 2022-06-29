using System;

namespace VisualProgramming6_Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            newClass myobj = new newClass();
            newClass myobj1 = new newClass(2);

            circle cobj = new circle();
            circle cobj1;                      //object is declared but not initialized.
            cobj1 = cobj;                    // we've assigned the class instance to the other object.

            double res = cobj.Area();        
    }

    class newClass
    {
        public newClass()
        {

            Console.WriteLine("Default Constructor");

        }
        public newClass(int a)
        {

        }
        public newClass(int a, int b)
        {

        }

    }

    class circle
    {
        private int Radius;      
        public double Area()   //without public access specifier this function can't be accessed otherwhere.
                               // public specifiers must start with capital alphabet.
            {
                return Math.PI * Radius * Radius;
        }
    }
}
