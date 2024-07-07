using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;




namespace PhoneBookApp
{
    public partial class PhoneBook
    {
        private Dictionary<string, Contact> phoneBook;

        public PhoneBook()
        {
            phoneBook = new Dictionary<string, Contact>();
        }

        public void AddEntry(string name, string phoneNumber, DateTime birthDate)
        {
            if (!phoneBook.ContainsKey(name))
            {
                phoneBook[name] = new Contact { PhoneNumber = phoneNumber, BirthDate = birthDate };
                Console.WriteLine($"Entry added: {name} - {phoneBook[name].PhoneNumber} - {birthDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"Entry already exists for {name}");
            }
        }

        public void UpdateEntry(string name, string newPhoneNumber, DateTime newBirthDate)
        {
            if (phoneBook.ContainsKey(name))
            {
                phoneBook[name] = new Contact { PhoneNumber = newPhoneNumber, BirthDate = newBirthDate };
                Console.WriteLine($"Entry updated: {name} - {phoneBook[name].PhoneNumber} - {newBirthDate.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"No entry found for {name}");
            }
        }

        public string SearchEntry(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                var entry = phoneBook[name];
                return $"{name}: {entry.PhoneNumber}, {entry.BirthDate.ToShortDateString()}";
            }
            else
            {
                return $"No entry found for {name}";
            }
        }

        public void DeleteEntry(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                phoneBook.Remove(name);
                Console.WriteLine($"Entry deleted: {name}");
            }
            else
            {
                Console.WriteLine($"No entry found for {name}");
            }
        }

        public void DisplayAllEntries()
        {
            Console.WriteLine("Phone Book Entries:");
            foreach (var entry in phoneBook)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value.PhoneNumber} - {entry.Value.BirthDate.ToShortDateString()}");
            }
        }

        public List<string> SearchByLastFourDigits(string lastFourDigits)
        {
            var results = new List<string>();
            foreach (var entry in phoneBook)
            {
                if (entry.Value.PhoneNumber.EndsWith(lastFourDigits))
                {
                    results.Add($"{entry.Key}: {entry.Value.PhoneNumber}, {entry.Value.BirthDate.ToShortDateString()}");
                }
            }
            return results;
        }

        public List<string> SearchByBirthDate(DateTime birthDate)
        {
            var results = new List<string>();
            foreach (var entry in phoneBook)
            {
                if (entry.Value.BirthDate.Date == birthDate.Date)
                {
                    results.Add($"{entry.Key}: {entry.Value.PhoneNumber}, {entry.Value.BirthDate.ToShortDateString()}");
                }
            }
            return results;
        }
    }

    public class Contact
    {
        private string ?phoneNumber;

        public string PhoneNumber
        {
            get => FormatPhoneNumber(phoneNumber!);
            set
            {
                if (IsValidPhoneNumber(value))
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Invalid phone number format.");
                }
            }
        }

        public DateTime BirthDate { get; set; }

        private bool IsValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^\d{10}$");
        }

        private string FormatPhoneNumber(string number)
        {
            if (string.IsNullOrEmpty(number) || number.Length != 10)
            {
                return number;
            }

            return $"({number.Substring(0, 3)}) {number.Substring(3, 3)}-{number.Substring(6, 4)}";
        }
    }
}