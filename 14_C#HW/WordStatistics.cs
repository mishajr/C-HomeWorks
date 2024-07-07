using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public partial class PhoneBook
    {
        public static Dictionary<string, int> CountWordOccurrences(string text)
        {
            var words = text.ToLower().Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            return wordCount;
        }

        public static void DisplayStatistics(Dictionary<string, int> wordCount)
        {
            Console.WriteLine("Word Statistics:");
            Console.WriteLine("----------------");
            foreach (var entry in wordCount.OrderBy(entry => entry.Key))
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }

            Console.WriteLine($"Total unique words: {wordCount.Count}");
        }
    }
}