using System;
public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Welcome to my Calculator App!");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformAddition(calculator);
                    break;
                case "2":
                    PerformSubtraction(calculator);
                    break;
                case "3":
                    PerformMultiplication(calculator);
                    break;
                case "4":
                    PerformDivision(calculator);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program Misha Calculator. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        }
    }

    private static void PerformAddition(Calculator calculator)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = calculator.Add(num1, num2);
            Console.WriteLine($"Result of addition: {num1} + {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter valid integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private static void PerformSubtraction(Calculator calculator)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = calculator.Sub(num1, num2);
            Console.WriteLine($"Result of subtraction: {num1} - {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter valid integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private static void PerformMultiplication(Calculator calculator)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = calculator.Mul(num1, num2);
            Console.WriteLine($"Result of multiplication: {num1} * {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter valid integers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    private static void PerformDivision(Calculator calculator)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = calculator.Div(num1, num2);
            Console.WriteLine($"Result of division: {num1} / {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter valid integers.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
