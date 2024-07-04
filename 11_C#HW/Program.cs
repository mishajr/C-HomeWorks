using System;
using System.Linq;


namespace _11_C_HW
{
    class Program
    {
        delegate int CalculationDelegate(int[] array);
        delegate void ModificationDelegate(int[] array);
        delegate void MenuDelegate();

        static void Main(string[] args)
        {
            int[] array = { -1, 2, -3, 4, 5, -6, 7, 8, 9 };

            MenuDelegate[] mainMenuActions = {
                CalculationMenu,
                ModificationMenu
            };

            while (true)
            {
                ShowMenu("Choose the type of array operation:", new string[] { "Calculate value", "Modify array" });
                int mainChoice = GetValidInput(1, 2) - 1;
                mainMenuActions[mainChoice]();
            }
        }

        static void CalculationMenu()
        {
            CalculationDelegate[] calcOperations = {
                CountNegativeElements,
                SumOfElements,
                CountPrimeNumbers
            };

            ShowMenu("Choose a calculation operation:", new string[] { "Count negative elements", "Sum of all elements", "Count prime numbers" });
            int calcChoice = GetValidInput(1, 3) - 1;
            int[] array = { -1, 2, -3, 4, 5, -6, 7, 8, 9 };
            int result = calcOperations[calcChoice](array);
            Console.WriteLine("Result: " + result);
        }

        static void ModificationMenu()
        {
            ModificationDelegate[] modOperations = {
                ReplaceNegativesWithZero,
                SortArray,
                MoveEvenToFront
            };

            ShowMenu("Choose an array modification operation:", new string[] { "Replace all negative elements with 0", "Sort the array", "Move all even elements to the front" });
            int modChoice = GetValidInput(1, 3) - 1;
            int[] array = { -1, 2, -3, 4, 5, -6, 7, 8, 9 };
            modOperations[modChoice](array);
            Console.WriteLine("Modified array: " + string.Join(", ", array));
        }

        static void ShowMenu(string prompt, string[] options)
        {
            Console.WriteLine(prompt);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }
        }

        static int GetValidInput(int min, int max)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < min || choice > max)
            {
                Console.WriteLine($"Please enter a number between {min} and {max}.");
            }
            return choice;
        }

        static int CountNegativeElements(int[] array)
        {
            return array.Count(x => x < 0);
        }

        static int SumOfElements(int[] array)
        {
            return array.Sum();
        }

        static int CountPrimeNumbers(int[] array)
        {
            return array.Count(IsPrime);
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static void ReplaceNegativesWithZero(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) array[i] = 0;
            }
        }

        static void SortArray(int[] array)
        {
            Array.Sort(array);
        }

        static void MoveEvenToFront(int[] array)
        {
            int[] result = array.OrderBy(x => x % 2 != 0).ToArray();
            Array.Copy(result, array, array.Length);
        }
    }
}
