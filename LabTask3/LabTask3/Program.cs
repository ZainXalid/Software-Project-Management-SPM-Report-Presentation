using System;

namespace LabTask3
{
    class Program
    {
        static void Main(string[] args)
        {


 //Task1
            /*

                        Console.WriteLine("------------------Task 1---------------");
                        int[] numbers = new int[10];
                        bool purpose = true;

                        Console.WriteLine("Input 10 elements in the array:");

                        for(int i = 0; i<10; i++)
                        {

                            if (purpose == true)
                            {
                                Console.Write("Element -"+i+" : ");
                                numbers[i] = int.Parse(Console.ReadLine());
                            }

                            if(i==9 && purpose == true)
                            {
                                Console.Write("Elements in the array are: ");
                                purpose = false;

                                i = 0;
                            }

                            if (purpose == false)
                            {
                                Console.Write(numbers[i] + " ");  
                        }                       
                        }
              */


//Task2
            /*   Console.WriteLine("------------------Task 2---------------");
             Console.WriteLine("Frequency of Numbers in an array");
               int[] numbers = new int[10];

               int i,j;

               Console.WriteLine("Input 10 elements in the array:");

               for(i = 0; i<10; i++)
               { 
                   Console.Write("Element - " + i + " : ");
                   numbers[i] = int.Parse(Console.ReadLine());

               }

               Console.WriteLine("Frequency of all elements of array :");




               for (i = 0; i <= 9; ++i)
               {
                   int count = 0;


                   for (j = 0; j <= 9; ++j)
                   {
                       if (numbers[i] == numbers[j])
                       { ++count; }
                   }

                   int k = i;

                   if (i != 0)
                   {  while (k > 0 && numbers[i] != numbers[k - 1] )
                       {
                           if(k==1)
                           Console.WriteLine(numbers[i] + " occurs " + count + " times");

                           k--;
                       } }
                   else
                       Console.WriteLine(numbers[i] + " occurs " + count + " times");


               }
            */

//Task3

            /*
            Console.WriteLine("--------------Task3----------------");

            Console.WriteLine("Input the number of elements to be stored in array :");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            int input, countEven = 0, countOdd = 0;

            for(int i=0; i<size;i++)
            {
                Console.Write("Elemtent -" + i + " : ");
                input = int.Parse(Console.ReadLine());

                arr[i] = input;
                
                if (input % 2 == 0)
                    countEven++;
                else
                    countOdd++;
            }

            int[] even = new int[countEven];
            int[] odd = new int[countOdd];

            int x=0, y=0;
            for (int i =0; i<size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[x] = arr[i];
                    x++;
                    }
                else
                {
                    odd[y] = arr[i];
                    y++;
                }
            }

            Console.WriteLine("\nThe Even elements are:");
            for(int a = 0; a<countEven; a++)
            {
                Console.Write(even[a] + " ");
            }

            Console.WriteLine("\nThe Odd elements are:");
            for (int b = 0; b < countOdd; b++)
            {
                Console.Write(odd[b] + " ");
            }
            */
        }
    }
}
