using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS_LR3_Task1
{
    internal class Program
    {
        static Queue<int> CreateQueue(int[] numbers)
        {
            Queue<int> queue = new Queue<int>();
            foreach (int num in numbers)
            {
                queue.Enqueue(num);
            }
            return queue;
        }

        static void SwapFirstAndLast(Queue<int> queue)
        {
            if (queue.Count > 1)
            {
                int[] queueArray = queue.ToArray();
                int temp = queueArray[0];
                queueArray[0] = queueArray[queueArray.Length - 1];
                queueArray[queueArray.Length - 1] = temp;

                queue.Clear();
                foreach (int num in queueArray)
                {
                    queue.Enqueue(num);
                }
                Console.WriteLine("Перше i останнє число помiняно мiсцями.");
            }
            else
            {
                Console.WriteLine("Має бути принаймнi два елементи для обмiну.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введiть числа через пробiл для створення черги:");
            string input = Console.ReadLine();

            int[] numbers = Array.ConvertAll(input.Split(), int.Parse);

            Queue<int> queue = CreateQueue(numbers);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Черга створена:");
            Console.ResetColor();
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            SwapFirstAndLast(queue);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Оновлена черга:");
            Console.ResetColor();
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
