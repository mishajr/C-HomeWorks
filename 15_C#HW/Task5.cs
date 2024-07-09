using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public static class Task5
{
    public static void SearchInFile()
    {
        Console.Write("Enter file path: ");
        string? filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {

            try
            {


                string content = File.ReadAllText(filePath);





             
                Console.Write("Enter the word to search: ");
                string? word = Console.ReadLine();
                bool found = content.Contains(word!);


                Console.WriteLine(found ? $"Word \"{word}\" found." : $"Word \"{word}\" not found.");

                

                int wordCount = Regex.Matches(content, word!).Count;
                Console.WriteLine($"Word \"{word}\" found {wordCount} times.");



               
                string reversedWord = new string(word!.Reverse().ToArray());
                int reversedWordCount = Regex.Matches(content, reversedWord).Count;

                Console.WriteLine($"Reversed word \"{reversedWord}\" found {reversedWordCount} times.");


            }
            catch (Exception ex)
            {


                Console.WriteLine($"An error occurred while processing the file: {ex.Message}");

            }
        }
        else
        {

            Console.WriteLine("Error: file not found.");


        }
    }
}
