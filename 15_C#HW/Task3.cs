using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public static class Task3
{
    public static void LoadArrayFromFile()
    {


        Console.Write("Enter the file path to load the array: ");
        string? filePath = Console.ReadLine();



        if (File.Exists(filePath))
        {
            try
            {

                string[] lines = File.ReadAllLines(filePath);
                int[] array = Array.ConvertAll(lines, int.Parse);


                Console.WriteLine("Loaded array:");


                foreach (int element in array)
                {
                    Console.WriteLine(element);
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");

            }
        }
        else
        {

            Console.WriteLine("Error: file not found.");

        }
    }
}
