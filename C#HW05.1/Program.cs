using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{


    private static List<Worker> workers = new List<Worker>();


    public static void Main()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine();

            Console.WriteLine("Menu:");

            Console.WriteLine("1. Add a Worker");

            Console.WriteLine("2. Show all Workers");

            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice (1-3): ");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddWorker();
                    break;
                case "2":
                    ShowWorkers();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 3.");
                    break;
            }
        }
    }

 
    private static void AddWorker()
    {
        try
        {
            Console.WriteLine();
            Console.WriteLine("Enter first name: ");

            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");

            string lastName = Console.ReadLine();


            Console.WriteLine("Enter patronymic: ");

            string patronymic = Console.ReadLine();

            Console.WriteLine("Enter age: ");

            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter salary: ");

            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter hire date (YYYY-MM-DD): ");

            DateTime hireDate = DateTime.Parse(Console.ReadLine());

            workers.Add(new Worker(firstName, lastName, patronymic, age, salary, hireDate));

            Console.WriteLine("Worker added successfully.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format.");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

  
    private static void ShowWorkers()
    {
        Console.WriteLine();
        if (workers.Count == 0)
        {
            Console.WriteLine("No workers to display.");
        }
        else
        {
            Console.WriteLine("List of Workers:");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
