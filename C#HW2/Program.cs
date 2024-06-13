


using System.Text;


namespace C_HW2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();

            #region task 1

            //int[] array = { 1, 2, 2, 3, 4, 5, 6, 7, 8, 8, 9 };


            //int evenCount = 0;
            //int oddCount = 0;
            //int uniqueCount = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0)
            //    {
            //        evenCount++;
            //    }
            //    else
            //    {
            //        oddCount++;
            //    }
            //}


            //for (int i = 0; i < array.Length; i++)
            //{
            //    int count = 0;


            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 1)
            //    {
            //        uniqueCount++;
            //    }
            //}


            //Console.WriteLine("Кількість парних елементів: " + evenCount);
            //Console.WriteLine("Кількість непарних елементів: " + oddCount);
            //Console.WriteLine("Кількість унікальних елементів: " + uniqueCount);


            #endregion

            //=============================================


            #region task 2


            //int[] array = { 1, 2, 2, 3, 4, 5, 6, 7, 8, 8, 9 };

            //Console.WriteLine("Введіть значення порогу : ");


            //int threshold = int.Parse(Console.ReadLine());


            //int countLessThanThreshold = 0;


            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] < threshold)
            //    { 

            //        countLessThanThreshold++;

            //    }
            //}


            //Console.WriteLine($"Кількість значень менших за {threshold}  :   {countLessThanThreshold}");
            #endregion

            //=============================================




            #region task 3
            //int[] A = new int[5];
            //double[,] B = new double[3, 4];


            //Console.WriteLine("Введіть 5 цілих чисел для масиву A:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = int.Parse(Console.ReadLine());
            //}



            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        B[i, j] = random.NextDouble() * 100; 
            //    }
            //}

            //Console.WriteLine("Масив A:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i] + " ");
            //}
            //Console.WriteLine();


            //Console.WriteLine("Масив B:");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        Console.Write($"{B[i, j]:F2} ");
            //    }
            //    Console.WriteLine();
            //}

            //double maxElement = double.MinValue;
            //double minElement = double.MaxValue;
            //double totalSum = 0;
            //double totalProduct = 1;

            //foreach (int value in A)
            //{
            //    if (value > maxElement) maxElement = value;
            //    if (value < minElement) minElement = value;
            //    totalSum += value;
            //    totalProduct *= value;
            //}

            //foreach (double value in B)
            //{
            //    if (value > maxElement) maxElement = value;
            //    if (value < minElement) minElement = value;
            //    totalSum += value;
            //    totalProduct *= value;
            //}


            //int sumEvenA = 0;
            //foreach (int value in A)
            //{
            //    if (value % 2 == 0)
            //    {
            //        sumEvenA += value;
            //    }
            //}


            //double sumOddColumnsB = 0;
            //for (int j = 1; j < B.GetLength(1); j += 2)
            //{
            //    for (int i = 0; i < B.GetLength(0); i++)
            //    {
            //        sumOddColumnsB += B[i, j];
            //    }
            //}


            //Console.WriteLine($"Максимальний елемент: {maxElement:F2}");
            //Console.WriteLine($"Мінімальний елемент: {minElement:F2}");
            //Console.WriteLine($"Загальна сума всіх елементів: {totalSum:F2}");
            //Console.WriteLine($"Загальний добуток всіх елементів: {totalProduct:F2}");
            //Console.WriteLine($"Сума парних елементів масиву A: {sumEvenA}");
            //Console.WriteLine($"Сума елементів непарних стовпців масиву B: {sumOddColumnsB:F2}");

            #endregion

            //=============================================



            #region task 4


            //int[,] array = new int[5, 5];



            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = random.Next(-100, 101);
            //    }
            //}


            //Console.WriteLine("Двовимірний масив:");
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write($"{array[i, j],5} ");
            //    }
            //    Console.WriteLine();
            //}


            //int minElem = array[0, 0];
            //int maxElem = array[0, 0];
            //int minIndexI = 0, minIndexJ = 0;
            //int maxIndexI = 0, maxIndexJ = 0;

            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] < minElem)
            //        {
            //            minElem = array[i, j];
            //            minIndexI = i;
            //            minIndexJ = j;
            //        }
            //        if (array[i, j] > maxElem)
            //        {
            //            maxElem = array[i, j];
            //            maxIndexI = i;
            //            maxIndexJ = j;
            //        }
            //    }
            //}

            //int sumBetween = 0;
            //bool counting = false;

            //if ((minIndexI < maxIndexI) || (minIndexI == maxIndexI && minIndexJ < maxIndexJ))
            //{

            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            if (i == minIndexI && j == minIndexJ)
            //            {
            //                counting = true;
            //            }
            //            if (counting)
            //            {
            //                sumBetween += array[i, j];
            //            }
            //            if (i == maxIndexI && j == maxIndexJ)
            //            {
            //                counting = false;
            //            }
            //        }
            //    }
            //}
            //else
            //{

            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            if (i == maxIndexI && j == maxIndexJ)
            //            {
            //                counting = true;
            //            }
            //            if (counting)
            //            {
            //                sumBetween += array[i, j];
            //            }
            //            if (i == minIndexI && j == minIndexJ)
            //            {
            //                counting = false;
            //            }
            //        }
            //    }
            //}


            //Console.WriteLine($"Мінімальний елемент: {minElem} (індекси [{minIndexI}, {minIndexJ}])");
            //Console.WriteLine($"Максимальний елемент: {maxElem} (індекси [{maxIndexI}, {maxIndexJ}])");
            //Console.WriteLine($"Сума елементів між мінімальним і максимальним: {sumBetween}");

            #endregion

            //=============================================



            #region task 5
            int[] array = { 7, 2, 5, 10, 3, 6, 12, 9, 4 };

            Console.WriteLine("Масив:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

          
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool dif5 = true;

                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && Math.Abs(array[i] - array[j]) != 5)
                    {
                        dif5 = false;
                        break;
                    }
                }

                if (dif5)
                {
                    count++;
                }
            }

      
            Console.WriteLine($"Кількість елементів, що відрізняються від інших на 5 одиниць: {count}");

            #endregion

            //=============================================


        }
    }
}
