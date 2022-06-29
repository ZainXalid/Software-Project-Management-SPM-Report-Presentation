using System;

namespace OS_Scheduling_Algorithm_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] userCredentials = new string[2, 4] { { "zainkhalid", "ahmerbarkat", "zohaibmehmood", "moeedmasood" }, { "112", "177", "087", "091" } };

            String userName, password;
             bool pass = false;
            Console.WriteLine("Enter Your Name     : ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter Your Password : ");
            password = Console.ReadLine();
  
                    for (int i =0; i<userCredentials.GetLength(1); i++)
                {
                    if (userName == userCredentials[0, i] && password == userCredentials[1, i])
                    {
                        pass = true;
                        break;
                    }}

            if(pass)
            {
                Console.WriteLine("Zain Khalid      FA19-BCS-112");
                Console.WriteLine("Ahmer Barkat     FA19-BCS-177");
                Console.WriteLine("Moeed Masood     FA19-BCS-091");
                Console.WriteLine("Zohaib Mehmood   FA19-BCS-087");
                Console.Write("\n\nPress y to continue : ");
                String button = Console.ReadLine();

                if (button == "y")
                {
                    int choice;
                    bool repeat = false;
                    String loop = "";
                    do
                    {
                        repeat = false;
                        Console.WriteLine("Select an algorithim for Process Scheduling");
                        Console.WriteLine("1. FCFS\n2. SJF\n3. PQ\n4. RR\n5. MultiLevel Queue");
                        choice = int.Parse(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("FCFS");

                                    Console.WriteLine("Press y to schedule Algorithim Again else press anykey to exit!");
                                    loop = Console.ReadLine();
                                    if (loop == "y" || loop == "Y")
                                        repeat = true;
                                    else
                                        Console.WriteLine("Scheduling Complete...  Exited");
                                    
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("SJF");

                                    Console.WriteLine("Press y to schedule Algorithim Again else press anykey to exit!");
                                    loop = Console.ReadLine();
                                    if (loop == "y" || loop == "Y")
                                        repeat = true;
                                    else
                                        Console.WriteLine("Scheduling Complete...  Exited");
                                    break;
                                }
                            case 3:
                                {
                                    Console.WriteLine("PQ");
                                    Console.WriteLine("Press y to schedule Algorithim Again else press anykey to exit!");
                                    loop = Console.ReadLine();
                                    if (loop == "y" || loop == "Y")
                                        repeat = true;
                                    else
                                        Console.WriteLine("Scheduling Complete...  Exited");
                                    break;
                                }
                            case 4:
                                {
                                    Console.WriteLine("RR");
                                    Console.WriteLine("Press y to schedule Algorithim Again else press anykey to exit!");
                                    loop = Console.ReadLine();
                                    if (loop == "y" || loop == "Y")
                                        repeat = true;
                                    else
                                        Console.WriteLine("Scheduling Complete...  Exited");
                                    break;
                                }
                            case 5:
                                {
                                    Console.WriteLine("MultiLevelQueue");
                                    Console.WriteLine("Press y to schedule Algorithim Again else press anykey to exit!");
                                    loop = Console.ReadLine();
                                    if (loop == "y" || loop == "Y")
                                        repeat = true;
                                    else
                                        Console.WriteLine("Scheduling Complete...  Exited");
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Invalid Scheduling Algorithm Selected. Please try Again!");
                                    repeat = true;
                                    break;
                                }
                        }

                    }
                    while (repeat);

                    
                }
                else
                    Console.WriteLine("\nExited!");
            }
            else
            {
                Console.WriteLine("\nInvalid User Name or Password ");
            }
                

        }
    }
}
