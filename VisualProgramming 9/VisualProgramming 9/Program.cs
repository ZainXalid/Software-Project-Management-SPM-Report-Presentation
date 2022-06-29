using System;

namespace VisualProgramming_9
{

    class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FlyingBird B1 = new FlyingBird();
            NonFlyingBird B2 = new NonFlyingBird();

            
        }
    }
    class Bird
    {

        public string survivability = " Birds are small and have high manevrability";

    }

    class FlyingBird : Bird
    {
        public static void ability () 
            {
            Console.WriteLine("Flight is the main ability.");
            }
     }

    class NonFlyingBird : Bird
    {
        public static void ability()
        {
            Console.WriteLine("Hiding is the main ability.");
        }
    }

    class Robin : FlyingBird
    {
      public static void type()
        {
            Console.WriteLine("Asian Hot Weather Bird");
        }
    }

    class Swallow : FlyingBird
    {
        public static void type()
        {
            Console.WriteLine("European Hot Weather Bird");
        }

    }

    class Penguin : NonFlyingBird
    {
        public static void type()
        {
            Console.WriteLine("Arctic Cold Weather Bird");
        }
    }

    class Kiwi : NonFlyingBird
    {
        public static void type()
        {
            Console.WriteLine("Australian Normal Weather Bird");
        }

    }
}
