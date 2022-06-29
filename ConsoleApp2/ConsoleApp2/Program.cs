using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bird f1 = new bird();
            f1.Fly();
            f1.Color();

            bird p1 = new bird();
            p1.Fly();
            p1.Color();

            bird s1 = new bird();
            s1.Fly();
            s1.Color();

            bird c1 = new bird();
            c1.Fly();
            c1.Color();


        }
    }

    class bird
    {
        public bird()
        {

        }

        public void Fly()
        {
            Console.WriteLine(" Fly Bird Class ");
        }

        public void Color()
        {
            Console.WriteLine(" Color Bird Class ");
        }
    }

    class parrot : bird
    {

        public virtual void Fly()
        {
            Console.WriteLine(" Fly Bird Class ");
        }

        public override void Color()
        {
            Console.WriteLine(" Color Bird Class ");
        }

    }

    class sparrow : bird
    {
        public virtual void Fly()
        {
            Console.WriteLine(" Fly Sparrow Class ");
        }

        public override void Color()
        {
            Console.WriteLine(" Color Sparrow Brown ");
        }
    }

    class crow : bird
    {
        public virtual void Fly()
        {
            Console.WriteLine(" Fly Crow Class ");
        }

        public override void Color()
        {
            Console.WriteLine(" Color Crow Black ");
        }
    }
}


