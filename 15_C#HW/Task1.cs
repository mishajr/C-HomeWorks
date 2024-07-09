using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
public static class Task1
{
    public static void DisplayFileContent()
    {

        Console.Write("Enter file path: ");
        string? filePath = Console.ReadLine();


        if (File.Exists(filePath))
        {

            try
            {

                string content = File.ReadAllText(filePath);

                Console.WriteLine("File content:");

                Console.WriteLine(content);

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
