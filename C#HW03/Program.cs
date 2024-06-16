using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            #region
            //Console.Write("Enter the original string: ");



            //string originalString = Console.ReadLine();



            //Console.Write("Enter the string to insert: ");


            //string stringToInsert = Console.ReadLine();

            //Console.Write("Enter the insert position: ");


            //if (int.TryParse(Console.ReadLine(), out int insertPosition))
            //{
            //    if (insertPosition >= 0 && insertPosition <= originalString.Length){

            //        string result = originalString.Insert(insertPosition-1, stringToInsert);

            //        Console.WriteLine("Original String: " + originalString);

            //        Console.WriteLine("String to Insert: " + stringToInsert);

            //        Console.WriteLine("Insert Position: " + insertPosition);


            //        Console.WriteLine("Resulting String: " + result);
            //    }
            //    else
            //    {

            //        Console.WriteLine("Insert position is out of bounds.");
            //    }
            //}
            //else
            //{

            //    Console.WriteLine("Invalid input for insert position. Please enter a valid integer.");
            //}
            #endregion
            #region


            //    Console.Write("Enter a string: ");

            //    string inputString = Console.ReadLine();

            //    if (IsPalindrome(inputString))
            //    {

            //        Console.WriteLine("The string is a palindrome.");
            //    }
            //    else
            //    {

            //        Console.WriteLine("The string is not a palindrome.");
            //    }
            //}

            //static bool IsPalindrome(string str)
            //{

            //    string cleanedString = CleanString(str);


            //    string reversedString = ReverseString(cleanedString);


            //    return cleanedString == reversedString;
            //}

            //static string CleanString(string str)
            //{

            //    char[] arr = str.ToLower().ToCharArray();

            //    char[] cleanedArr = Array.FindAll(arr, char.IsLetterOrDigit);

            //    return new string(cleanedArr);
            //}

            //static string ReverseString(string str)
            //{
            //    char[] arr = str.ToCharArray();

            //    Array.Reverse(arr);

            //    return new string(arr);

            //}
            #endregion
            #region

            //Console.Write("Enter the text: ");

            //string inputText = Console.ReadLine();

            //int totalChars = inputText.Length;

            //int upperCaseCount = 0;

            //int lowerCaseCount = 0;

            //foreach (char c in inputText)
            //{
            //    if (char.IsUpper(c))
            //    {
            //        upperCaseCount++;

            //    }
            //    else if (char.IsLower(c))
            //    {
            //        lowerCaseCount++;

            //    }
            //}

            //double upperCasePercentage = (double)upperCaseCount / totalChars * 100;

            //double lowerCasePercentage = (double)lowerCaseCount / totalChars * 100;

            //Console.WriteLine($"Total characters: {totalChars}");


            //Console.WriteLine($"Uppercase letters: {upperCaseCount} ({upperCasePercentage:F2}%)");
            //Console.WriteLine($"Lowercase letters: {lowerCaseCount} ({lowerCasePercentage:F2}%)");

            #endregion
            #region

            //    Console.Write("Enter words separated by spaces: ");

            //    string input = Console.ReadLine();

            //    string[] words = input.Split(' ');


            //    Console.Write("Enter the length of words to modify: ");

            //    if (int.TryParse(Console.ReadLine(), out int targetLength))
            //    {
            //        for (int i = 0; i < words.Length; i++)
            //        {
            //            if (words[i].Length == targetLength)
            //            {
            //                words[i] = ReplaceLastThreeChars(words[i]);

            //            }
            //        }

            //        string result = string.Join(" ", words);

            //        Console.WriteLine("Modified words: " + result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input for the length.");

            //    }
            //}

            //static string ReplaceLastThreeChars(string word)
            //{
            //    if (word.Length < 3)
            //    {
            //        return word; 

            //    }

            //    return word.Substring(0, word.Length - 3) + "$$$";

            //Зробив так,як зрозумів питання 


            #endregion
            #region



            //Console.Write("Enter the text: ");

            //string inputText = Console.ReadLine();


            //Console.Write("Enter the word position (starting from 1): ");

            //if (int.TryParse(Console.ReadLine(), out int wordPosition))
            //{
            //    string[] words = inputText.Split(' ');

            //    if (wordPosition > 0 && wordPosition <= words.Length)
            //    {
            //        string word = words[wordPosition - 1]; 

            //        char firstLetter = word[0];

            //        Console.WriteLine($"The first letter of word at position {wordPosition} is: {firstLetter}");

            //    }
            //    else
            //    {
            //        Console.WriteLine("Word position is out of range.");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input for word position.");

            //}
            #endregion
            #region
            //Console.Write("Enter the string of words: ");

            //string input = Console.ReadLine();

           
            //string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

          
            //string result = string.Join("*", words);

     
            //Console.WriteLine("Modified string: " + result);
            #endregion
            #region


            //StringBuilder sb = new StringBuilder();

            //string input;

            //bool endInput = false;

            //Console.WriteLine("Enter words. Input stops when a word ends with a period ('.')");

            //while (!endInput)
            //{
            //    input = Console.ReadLine();

            //    if (!string.IsNullOrWhiteSpace(input))
            //    {
            //        if (input.EndsWith('.'))
            //        {

            //            endInput = true;
            //        }

            //        if (sb.Length > 0)
            //        {
            //            sb.Append(", ");

            //        }
            //        sb.Append(input);
            //    }
            //}

            //string result = sb.ToString();

            //Console.WriteLine("Resulting string: " + result);

            #endregion
        }
    }
}

