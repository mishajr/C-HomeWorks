using System;
using System.Collections.Generic;
using System.Linq;


namespace _13_C_HW
{
   

    public static class StringExtensions
    {




        public static string Encrypt(this string input, int key)
        {

            char[] buffer = input.ToCharArray();


            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] + key);
            }

            return new string(buffer);
        }





        public static string Decrypt(this string input, int key)
        {
            char[] buffer = input.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (char)(buffer[i] - key);
            }

            return new string(buffer);
        }
    }




    public static class ArrayExtensions
    {
        public static Dictionary<T, int> CountDuplicates<T>(this T[] array) => array.GroupBy(x => x).Where(g => g.Count() > 1).ToDictionary(g => g.Key, g => g.Count());
    }




    class Program
    {

        static void Main(string[] args)
        {

            string text = "Привіт";

            int key = 3;


            string encryptedText = text.Encrypt(key);


            string decryptedText = encryptedText.Decrypt(key);




            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Encrypted: {encryptedText}");
            Console.WriteLine($"Decrypted: {decryptedText}");


            
            int[] array = { 1, 2, 2, 3, 3, 3, 4, 5 };




            Dictionary<int, int> duplicates = array.CountDuplicates();


            foreach (var kvp in duplicates)
            {
                Console.WriteLine($"Element {kvp.Key} appears {kvp.Value} times");
            }
        }
    }

}
