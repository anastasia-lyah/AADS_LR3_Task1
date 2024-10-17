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
        static void ClearQueue(Queue<int> queue)
        {
            queue.Clear();
            Console.WriteLine("Чергу очищено.");
        }
        static void EnqueueElement(Queue<int> queue, int element)
        {
            queue.Enqueue(element);
            Console.WriteLine($"Елемент {element} додано до черги.");
        }
        static int DequeueElement(Queue<int> queue)
        {
            if (queue.Count > 0)
            {
                int removedElement = queue.Dequeue();
                Console.WriteLine($"Елемент {removedElement} видалено з черги.");
                return removedElement;
            }
            else
            {
                Console.WriteLine("Черга порожня.");
                return -1;
            }
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
            int[] numbers = { 11, 22, 33, 44, 55 };
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

            DequeueElement(queue);

            EnqueueElement(queue, 66);

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Оновлена черга:");
            Console.ResetColor();
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            ClearQueue(queue);
        }
    }
}
