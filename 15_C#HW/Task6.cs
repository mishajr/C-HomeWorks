using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public static class Task6
{
    public static void DisplayFileStatistics()
    {

        Console.Write("Enter file path: ");
        string? filePath = Console.ReadLine();




        if (File.Exists(filePath))
        {

            try
            {

                string content = File.ReadAllText(filePath);


                
                int sentenceCount = Regex.Matches(content, @"[.!?]").Count;


                int upperCaseCount = content.Count(char.IsUpper);



                int lowerCaseCount = content.Count(char.IsLower);



                int vowelCount = content.Count(c => "AEIOUaeiou".Contains(c));


                int consonantCount = content.Count(c => "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz".Contains(c));



                int digitCount = content.Count(char.IsDigit);



                Console.WriteLine($"Number of sentences: {sentenceCount}");


                Console.WriteLine($"Number of uppercase letters: {upperCaseCount}");


                Console.WriteLine($"Number of lowercase letters: {lowerCaseCount}");


                Console.WriteLine($"Number of vowels: {vowelCount}");


                Console.WriteLine($"Number of consonants: {consonantCount}");


                Console.WriteLine($"Number of digits: {digitCount}");


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
