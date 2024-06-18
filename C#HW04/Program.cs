using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Freezer[] freezers = new Freezer[5];

        for (int i = 0; i < freezers.Length; i++)
        {
       
            Console.WriteLine($"Введіть дані для морозильної камери {i + 1}:");

            Console.WriteLine("Бренд: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Ємність (л): ");
            double capacity;
            while (!double.TryParse(Console.ReadLine(), out capacity) || capacity <= 0)
            {
                Console.WriteLine("Будь ласка, введіть правильне значення для ємності: ");
            }

            Console.WriteLine("Температура (°C, між -30 і 0): ");
            int temperature;
            while (!int.TryParse(Console.ReadLine(), out temperature) || temperature > 0 || temperature < -30)
            {
                Console.WriteLine("Будь ласка, введіть правильне значення для температури: ");
            }

            Console.WriteLine("No Frost (true/false): ");
            bool isNoFrost;
            while (!bool.TryParse(Console.ReadLine(), out isNoFrost))
            {
                Console.WriteLine("Будь ласка, введіть правильне значення для No Frost (true/false): ");
            }

            Console.WriteLine("Енергетичний клас: ");
            string energyClass = Console.ReadLine();

           
            freezers[i] = new Freezer(brand, capacity, temperature, isNoFrost, energyClass);
        }

        Console.WriteLine("\nІнформація про всі морозильні камери:");
        foreach (var freezer in freezers)
        {
            freezer.DisplayInfo();
        }
    }
}
