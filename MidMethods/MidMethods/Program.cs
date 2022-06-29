using System;

namespace MidMethods

{


    class Program
    {
        
        static void Main(string[] args)
        {
            int choice,loop=1;
        
            double pricePerLiter = 100;
            do
            {
                Console.Write("Price\n1. Set Fuel Price\n2. Car Information.\n3. Exit");
                choice = System.Int32.Parse(Console.ReadLine());

                if(choice==1)
                {
                    pricePerLiter = System.Int32.Parse(Console.ReadLine());
                    Car.setPricePerLiter(pricePerLiter);
                }
                else
                if(choice == 2)
                {
                    Console.Write("Enter Car Name : ");
                    String carName = Console.ReadLine();
                    Console.Write("Enter fuel Capacity : ");
                    double fuelCapacity = System.Int32.Parse(Console.ReadLine());
                    Console.Write("Enter Current Fuel Level : ");
                    double fuelLevel = System.Int32.Parse(Console.ReadLine());
                    Console.Write("Enter Average Consumption : ");
                    double  avgConsumption = System.Int32.Parse(Console.ReadLine());

                    Car obj = new Car(carName, fuelCapacity, fuelLevel, avgConsumption);
                    obj.addFuel(15);

                    obj.expectedCoverage();
                }
                if(choice == 3)
                {
                    Console.WriteLine("Exiting");
                    break;
                }
            }
            while (loop == 1 || loop == 2 || loop == 3) ;
         
 

           

           


        }

                 

    }
}
