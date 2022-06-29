using System;

namespace ClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            String season;
            Console.WriteLine("Enter Current Month Number : ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month >= 5 && month <= 8)
                season = "Summer";
            else
             if (month == 11 || month == 12 || month == 2 || month == 1)
                season = "Winter";
            else
            if (month == 3 || month == 4)
                season = "Spring";
            else
            if (month == 9 || month == 10)
                season = "Autumn";
            else
                Console.WriteLine("Invalid Input;");

            Console.WriteLine("Current Season : " + season);


        }
    }
}
