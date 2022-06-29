using System;

namespace VisualProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            myclass myobj = new myclass();
            myobj.Y = 10;
            int val = myobj.Y;


            Demo obj = new Demo();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Max Generation are " + GC.MaxGeneration);
            Console.WriteLine("Generation number of my object is " + GC.GetGeneration(obj) );
            Console.WriteLine("Total Memory " + GC.GetTotalMemory(false));
            GC.Collect(0);
            Console.WriteLine("Collect Garabage in Gen0 " + GC.CollectionCount(0));
      
        }
    }

    class Demo
    {

    }

    class myclass
    {

        private int y;
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

    }
}
