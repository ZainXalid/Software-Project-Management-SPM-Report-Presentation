using System;

namespace VisualProgramming3
{
    class Program
    {
        static void Main(string[] args)
        {
        
          /*  Console.WriteLine("Hello World!");
            int num1 = 5;
            int num2 = 10;
            square(num1, num2);
            Console.WriteLine(num1 + "  " + num2);
          */
            person p1 = new person();
            person p2 = new person();

            p1.age = 5;
            p2.age = 10;

            Console.WriteLine(p1.age + "  " + p2.age);
            squareref(p1, p2);
            Console.WriteLine(p1.age + "  " + p2.age);
        }

     /*   static void square(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + "  " + b);

        }
     */
        static void squareref(person a, person b)
        {
            a.age = a.age * a.age;
            b.age = b.age * b.age;
            Console.WriteLine(a.age+"  "+b.age);
        }
    }

    class person
    {
        public int age;
    }
}
