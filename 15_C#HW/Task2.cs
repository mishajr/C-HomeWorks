using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class Task2
{
    public static void SaveArrayToFile()
    {


        Console.Write("Enter the number of array elements: ");

        int n = int.Parse(Console.ReadLine()!);
        int[] array = new int[n];


        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine()!);
        }


        Console.Write("Enter the file path to save the array: ");
        string? filePath = Console.ReadLine();


        try
        {
            File.WriteAllLines(filePath!, Array.ConvertAll(array, element => element.ToString()));
            Console.WriteLine("Array saved to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while writing the file: {ex.Message}");
        }
    }
}