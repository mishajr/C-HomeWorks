using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("Введіть 5 чисел :");

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());
            //int num4 = int.Parse(Console.ReadLine());
            //int num5 = int.Parse(Console.ReadLine());

            //int sum = num1 + num2 + num3 + num4 + num5;
            //int max = num1;

            //if (num2 > max) max = num2;
            //if (num3 > max) max = num3;
            //if (num4 > max) max = num4;
            //if (num5 > max) max = num5;

            //int min = num1;
            //if (num2 < min) min = num2;
            //if (num3 < min) min = num3;
            //if (num4 < min) min = num4;
            //if (num5 < min) min = num5;

            //int product = num1 * num2 * num3 * num4 * num5;

            //Console.WriteLine($"Сума чисел: {sum}");
            //Console.WriteLine($"Максимальне число: {max}");
            //Console.WriteLine($"Мінімальне число: {min}");
            //Console.WriteLine($"Добуток чисел: {product}");


            //===========================================================================


            //Console.Write("Введіть шестизначне число: ");
            //string input = Console.ReadLine();




            //    string reversedNumber = "";
            //    for (int i = input.Length-1; i >= 0; i--)
            //    {
            //        reversedNumber += input[i];
            //    }


            //    Console.WriteLine($"Перевернуте число: {reversedNumber}");

            //===========================================================================


            //Console.Write("Введіть початок діапазону: ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Введіть кінець діапазону: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Числа Фібоначчі в діапазоні від {start} до {end}:");

            //int a = 0, b = 1;
            //while (b <= end)
            //{
            //    if (b >= start)
            //    {
            //        Console.Write(b + " ");
            //    }
            //    int temp = a;
            //    a = b;
            //    b = temp + b;
            //}

            //===========================================================================

            //Console.Write("Введіть число A: ");

            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Введіть число B : ");

            //int B = int.Parse(Console.ReadLine());


            //if (B <= A)
            //{
            //    Console.WriteLine("Помилка: B має бути більшим за A.");

            //    return;
            //}


            //for (int i = A; i <= B; i++)
            //{

            //    for (int j = 0; j < i; j++)
            //    {


            //        Console.Write(i + " ");

            //    }

            //    Console.WriteLine();

            //}


            //===========================================================================

             Console.Write("Введіть довжину лінії: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Введіть символ заповнювач: ");
            char fillChar = char.Parse(Console.ReadLine());

            Console.Write("Введіть напрямок лінії (горизонтальна-g або вертикальна-v): ");
            string direction = Console.ReadLine().ToLower();

            if (direction == "g")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(fillChar);
                }
            }
            if (direction == "v")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(fillChar);
                }
            }
            if(direction != "g" && direction != "v") 
            {
                Console.WriteLine("Помилка: неправильний напрямок лінії.");
                return;
            }



        }
    }
}