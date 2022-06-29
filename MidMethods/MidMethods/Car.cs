using System;
using System.Collections.Generic;
using System.Text;

namespace MidMethods
{
    class Car
    {
        String carName;
        double fuelCapacity;
        double fuelLevel;
        double avgConsumption;
        static double fuelPricePerLiter;

        public Car(String carName, double fuelCapacity, double fuelLevel,
            double avgConsumption)
        {
            this.carName = carName;
            this.fuelCapacity = fuelCapacity;
            this.fuelLevel = fuelLevel;
            this.avgConsumption = avgConsumption;

        }

        public static void setPricePerLiter(double PricePerLiter)
        {
             fuelPricePerLiter = PricePerLiter;
        }

        public void addFuel()
        {
            double emptyCapacity = fuelCapacity - fuelLevel;
            fuelLevel += emptyCapacity;
            Console.WriteLine("Fuel Tank Full.\nAdded " + emptyCapacity + " Liters fuel.\nTotal Price = "+emptyCapacity*fuelPricePerLiter);

        }

        public void addFuel(int addition)
        {
            if (addition <= fuelCapacity - fuelLevel)
            {
                fuelLevel += addition;
                Console.WriteLine("Fuel Tank Full.\nAdded " + addition + " Liters fuel.\nTotal Price = " + addition * fuelPricePerLiter);
            }
            else
                Console.WriteLine("Fuel Added exciding total Limit of "+fuelCapacity);
        }

        public void expectedCoverage()
        {
            Console.WriteLine("The expected Coverage is " + fuelLevel * avgConsumption + " for " + fuelLevel + " Litters of Fuel Remeining");
        }

    }
}
