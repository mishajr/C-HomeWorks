using System;
using System.Text;

namespace PhoneBookApp
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            PhoneBook phoneBook = new PhoneBook();

            phoneBook.AddEntry("John Doe", "1234567890", new DateTime(1991, 5, 12));
            phoneBook.AddEntry("Jane Smith", "0987654321", new DateTime(2001, 9, 11));

            Console.WriteLine(phoneBook.SearchEntry("John Doe"));
            Console.WriteLine(phoneBook.SearchEntry("Jake"));

            phoneBook.UpdateEntry("John Doe", "1112223333", new DateTime(1990, 5, 12));
            Console.WriteLine(phoneBook.SearchEntry("John Doe"));

            phoneBook.DeleteEntry("Jane Smith");

            phoneBook.DisplayAllEntries();

            var searchResults = phoneBook.SearchByLastFourDigits("3333");
            Console.WriteLine("\nSearch by last four digits (3333):");
            foreach (var result in searchResults)
            {
                Console.WriteLine(result);
            }

            var dateSearchResults = phoneBook.SearchByBirthDate(new DateTime(1990, 5, 12));
            Console.WriteLine("\nSearch by birth date (1990-05-12):");
            foreach (var result in dateSearchResults)
            {
                Console.WriteLine(result);
            }

            string text = @"Ось будинок, який збудував Джек. А це пшениця, яка
            у темній коморі зберігається у будинку, який збудував
            Джек. А це веселий птах-синиця, який часто краде
            пшеницю, яка в темній коморі зберігається у будинку,
            який збудував Джек.";

            var wordStatistics = PhoneBook.CountWordOccurrences(text);
            PhoneBook.DisplayStatistics(wordStatistics);
        }
    }
}
