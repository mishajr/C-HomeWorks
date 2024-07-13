using System;
using System.Linq;


namespace _18_C_HW
{
    

    class Program
    {
        static void Main()
        {

            int[] numbers = { -10, 20, 15, -3, 7, 0, 5, 25, -22, 33, -45 };

           
            var positiveNumbers = numbers.Where(n => n > 0).OrderBy(n => n);


            Console.WriteLine("Sorted positive numbers:");

            foreach (var number in positiveNumbers)
            {

                Console.WriteLine(number);

            }

         



            var positiveTwoDigitNumbers = numbers
                .Where(n => n > 0 && n >= 10 && n < 100);




            int count = positiveTwoDigitNumbers.Count();


            double average = positiveTwoDigitNumbers.Any() ? positiveTwoDigitNumbers.Average() : 0;

            Console.WriteLine($"Number of positive two-digit elements: {count}");
            Console.WriteLine($"Arithmetic mean of positive two-digit elements: {average}");
        }
    }

}
