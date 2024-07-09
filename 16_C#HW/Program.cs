using System;

namespace _16_C_HW
{
  

    class Program
    {
        static void Main()
        {
           
            Console.WriteLine("Task 1: Max of three numbers");
            Console.WriteLine(Task1.Max(3, 7, 5));
            Console.WriteLine(Task1.Max(2.5, 1.1, 3.8));
            Console.WriteLine(Task1.Max("apple", "banana", "cherry"));

          



            Console.WriteLine("\nTask 2: Min of three numbers");
            Console.WriteLine(Task2.Min(3, 7, 5));
            Console.WriteLine(Task2.Min(2.5, 1.1, 3.8));
            Console.WriteLine(Task2.Min("apple", "banana", "cherry"));

           



            Console.WriteLine("\nTask 3: Sum of array elements");
            Console.WriteLine(Task3.Sum(new int[] { 1, 2, 3, 4, 5 }));
            Console.WriteLine(Task3.Sum(new double[] { 1.1, 2.2, 3.3 }));

          



            Console.WriteLine("\nTask 4: Stack operations");
            var stack = new Stack<int>();


            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Stack peek: {stack.Peek()}");
            Console.WriteLine($"Stack pop: {stack.Pop()}");
            Console.WriteLine($"Stack count: {stack.Count}");

  
            Console.WriteLine("\nTask 5: Queue operations");
            var queue = new Queue<string>();

            queue.Enqueue("first");
            queue.Enqueue("second");
            queue.Enqueue("third");


            Console.WriteLine($"Queue peek: {queue.Peek()}");
            Console.WriteLine($"Queue dequeue: {queue.Dequeue()}");
            Console.WriteLine($"Queue count: {queue.Count}");




        }
    }
}
