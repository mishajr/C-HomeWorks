using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

public static class Task4
{
    public static void GenerateAndSaveNumbers()
    {


        int[] randomNumbers = new int[10000];
        Random rand = new Random();



        for (int i = 0; i < 10000; i++)
        {

            randomNumbers[i] = rand.Next();

        }


        var evenNumbers = randomNumbers.Where(num => num % 2 == 0).ToArray();
        var oddNumbers = randomNumbers.Where(num => num % 2 != 0).ToArray();


        try
        {

            File.WriteAllLines("evenNumbers.txt", Array.ConvertAll(evenNumbers, element => element.ToString()));
            File.WriteAllLines("oddNumbers.txt", Array.ConvertAll(oddNumbers, element => element.ToString()));

            Console.WriteLine("Even numbers saved to evenNumbers.txt");
            Console.WriteLine("Odd numbers saved to oddNumbers.txt");
            Console.WriteLine($"Number of even numbers: {evenNumbers.Length}");
            Console.WriteLine($"Number of odd numbers: {oddNumbers.Length}");


        }
        catch (Exception ex)
        {

            Console.WriteLine($"An error occurred while writing the files: {ex.Message}");

        }
    }
}