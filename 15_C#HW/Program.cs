
using System;

namespace _15_C_HW
{

    

    class Program
    {
        static void Main()
        {

            while (true)
            {

                Console.WriteLine("\nSelect a task:");



                Console.WriteLine("1. Display file content");

                Console.WriteLine("2. Save array to file");

                Console.WriteLine("3. Load array from file");

                Console.WriteLine("4. Generate and save random numbers");

                Console.WriteLine("5. Search in file");


                Console.WriteLine("6. Display file statistics");


                Console.WriteLine("7. Exit");


                int choice = int.Parse(Console.ReadLine()!);


                switch (choice)
                {

                    case 1:
                        Task1.DisplayFileContent();
                        break;


                    case 2:
                        Task2.SaveArrayToFile();
                        break;


                    case 3:
                        Task3.LoadArrayFromFile();
                        break;


                    case 4:
                        Task4.GenerateAndSaveNumbers();
                        break;


                    case 5:
                        Task5.SearchInFile();
                        break;


                    case 6:
                        Task6.DisplayFileStatistics();
                        break;
                    case 7:
                        return;





                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }



}
