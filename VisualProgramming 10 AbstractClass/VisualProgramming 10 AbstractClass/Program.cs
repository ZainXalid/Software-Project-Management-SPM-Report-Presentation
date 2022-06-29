using System;

namespace VisualProgramming_10_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            absDerived d = new absDerived();
            d.numbers = 5;


            Console.WriteLine(d.numbers);
        }

    }

    abstract class absclass
    {
        protected int myNumber;
        public abstract int numbers
        {
            get;
            set;
        }

        public void printv()
        {

        }

    }

    class absDerived : absclass
    {
        public override int numbers
        {
            get
            {
                return myNumber;
            }
            set
            {
                myNumber = value;
            }
        }
    }
}
