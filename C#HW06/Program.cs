using System.Text;



namespace C_HW06
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            #region 
            //try
            //{


            //    Console.Write("Введіть набір символів від 0 до 9: ");

            //    string userInput = Console.ReadLine();

                
            //    int number = int.Parse(userInput);

           
            //    if (number < int.MinValue || number > int.MaxValue)
            //    {
            //        Console.WriteLine($"Число {number} виходить за межі допустимого діапазону типу int.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Введене число: {number}");
            //    }


            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Введено некоректний набір символів. Будь ласка, введіть тільки цифри від 0 до 9.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Введене число виходить за межі допустимого діапазону типу int.");
            //}

            #endregion



            try
            {
     
                Card card = new Card("1234567812345678", "Іван Іванович Іванов", "123", new DateTime(2025, 12, 31));

               
                card.DisplayCardInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

        }
    }
}
