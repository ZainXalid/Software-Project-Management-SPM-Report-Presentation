using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            float num1, num2, answer;
            Char loop = 'y';
            Console.Write("    Calculator Console       \n\n");

            while (loop == 'y')
            {
                Console.Write("Press \n1 for addition \n2 for subtraction \n3 for multiplication \n4 for division \n");
           
                choice = Int32.Parse(Console.ReadLine());

                Console.Write("\n\n Enter 1st number : ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("\n Enter 2nd number : ");
                num2 = float.Parse(Console.ReadLine());

                Console.Write("\n\n");
                if (choice == 1)
                {
                    answer = num1 + num2;
                    Console.Write("Addition of " + num1 + " and " + num2 + " is : " + answer);
                }
                else
                if (choice == 2)
                {
                    answer = num1 - num2;
                    Console.Write("Subtraction of " + num1 + " and " + num2 + " is : " + answer);
                }
                else
                if (choice == 3)
                {
                    answer = num1 * num2;
                    Console.Write("Multiplication of " + num1 + " and " + num2 + " is : " + answer);
                }
                else
                if (choice == 4)
                {
                    if (num2 == 0)
                    {
                        Console.Write("Any number divided by '0' is undefined. ");
                    }
                    else
                    {
                        answer = num1 / num2;
                        Console.Write("Division of " + num1 + " and " + num2 + " is : " + answer);
                    }

                }
                else
                {
                    Console.Write("Invalid Entry");
                }

                Console.Write("\n\nDo you want try again?\nPress y/n");
                loop = Console.ReadLine()[0];
            }

   
        }

    }
}
